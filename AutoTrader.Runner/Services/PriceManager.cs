using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using AutoTrader.Models.Enums;
using AutoTrader.Models.Helpers;
using AutoTrader.Models.Interfaces;
using AutoTrader.Models.Models;
using AutoTrader.Models.Models.HistoricalData;
using AutoTrader.Yahoo.API.Contracts.FundamentalData.StubClasses;


namespace AutoTrader.Runner.Services
{
    public class PriceManager
    {
        private readonly IStockDataService _service;

        public PriceManager(IStockDataService service)
        {
            _service = service;
        }

        public async Task<IEnumerable<Price>> GetHistoricalDataAsync(Ticker ticker, int numOfDays)
        {
            try
            {
                var result = await _service.GetHistoricalDataAsync(
                    ticker.Symbol,
                    DateTime.Now.AddDays(-2 * numOfDays),
                    DateTime.Now,
                    Interval.OneDay,
                    true);

                return result.Prices.TakeLast(numOfDays).OrderBy(c => c.StartTime);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to get historical data for {ticker.Symbol}.\r\n{e}");
                return null;
            }
        }

        public async Task<List<Price>> GetPricesAsync(
            Ticker ticker,
            DateTime startTime,
            DateTime endTime,
            Interval frequency,
            bool includePrePost)
        {
            var history = await _service.GetHistoricalDataAsync(
                    ticker.Symbol,
                    startTime,
                    endTime,
                    frequency,
                    includePrePost);

            return history.Prices.ToList();
        }

        public List<Profit> CalculateProfits(IEnumerable<Price> prices)
        {
            // Group all prices by symbol
            var groupedList = prices.GroupByStock();

            // Calculate profit for each symbol
            var profits = groupedList.Select(grouped => new Profit
            {
                Symbol = grouped.Key,
                StartTime = grouped.First().StartTime,
                EndTime = grouped.Last().StartTime,
                ProfitPercentage = grouped.CalculateProfitPercentage()
            }).OrderBy(c => c.ProfitPercentage).ToList();

            var levelCount = 5;

            var divider = profits.Count / levelCount;

            for (var i = 0; i < profits.Count; i++)
            {
                profits[i].Rank = Convert.ToInt32(i / divider);
            }

            return profits.OrderBy(c => c.Symbol).ToList();
        }

        public MomentumDetail CalculateMomentum(List<Price> prices, DateTime cutTime, int numOfStocks)
        {
            prices = prices.SortByStartTime();

            if (numOfStocks > prices.GetStockNames().Count())
                throw new ArgumentException("numOfStocks cannot be bigger than total stock number");

            var trainPeriod = prices.TrimUntil(cutTime, true);

            var trainProfits = CalculateProfits(trainPeriod);

            var testPeriod = prices.TrimFrom(cutTime);

            var testProfits = CalculateProfits(testPeriod);

            var stocksToBuy = trainProfits.GetTopProfitableStocks(numOfStocks);

            var selectedStocksAverage = testProfits.Average(stocksToBuy);

            return new MomentumDetail
            {
                AllSymbols = trainPeriod.ConcatStockNames(testPeriod),
                TrainAverage = trainProfits.Average(),
                TestAverage = testProfits.Average(),
                StocksToBuy = stocksToBuy,
                StocksToBuyAverage = selectedStocksAverage
            };
        }

        public List<MomentumDetail> SlidingWindow(List<Price> prices, int trainDays, int testDays, int numOfStocks)
        {
            if (trainDays <= 0)
                throw new ArgumentException("trainDays must be positive");

            if (testDays <= 0)
                throw new ArgumentException("testDays must be positive");

            var daysCount = prices.DaysCount();

            if (testDays + trainDays > daysCount)
                throw new ArgumentException("total prices must be bigger than the sum of trainDays and testDays");

            var window = daysCount - (trainDays + testDays);

            var momentumList = new List<MomentumDetail>();

            for (var i = 0; i < window; i += 10)
            {
                var delta = i;

                var trainStartTime = prices.First().StartTime.AddDays(delta);
                var trainEndTime = trainStartTime.AddDays(trainDays);

                var testStartTime = trainEndTime.AddDays(1);
                var testEndTime = testStartTime.AddDays(testDays);

                var windowPrices = prices.BetweenDates(trainStartTime, testEndTime);

                momentumList.Add(CalculateMomentum(windowPrices, trainEndTime, numOfStocks));
            }

            return momentumList;
        }

        public List<ExtremaGroup> GetSupportExtremaGroups(List<Price> prices, ExtremaType extremePoint, double offsetPercent)
        {
            // Get extrema points
            var extremePoints = GetExtremePoints(prices, extremePoint, offsetPercent);

            // Filter broken limits
            extremePoints = FilterBrokenLimits(extremePoints, ExtremaType.Minimum, offsetPercent);

            // Merge group
            var extremaGroups = MergeGroups(extremePoints, 1);

            return extremaGroups;
        }

        public List<ExtremaGroup> GetRejectExtremaGroups(List<Price> prices, double offsetPercent)
        {
            var extremePoints = GetExtremePoints(prices, ExtremaType.Maximum, offsetPercent);

            // Filter broken limits
            extremePoints = FilterBrokenLimits(extremePoints, ExtremaType.Maximum, offsetPercent);

            // Merge group
            var extremaGroups = MergeGroups(extremePoints);

            return extremaGroups;
        }

        private static List<ExtremaGroup> MergeGroups(List<Extrema> extremePoints, int minCount = 0)
        {
            extremePoints = extremePoints.OrderByDescending(c => c.CurrentPrice.StartTime).ToList();

            var extremaGroups = new List<ExtremaGroup>();

            for (var i = 0; i < extremePoints.Count; i++)
            {
                var pointI = extremePoints[i];

                var group = new ExtremaGroup()
                {
                    pointI.CurrentPrice
                };

                var newIndex = i;
                for (var j = i + 1; j < extremePoints.Count; j++)
                {
                    var pointJ = extremePoints[j];

                    var valJ = extremePoints[j].CurrentPrice.Close;

                    if (valJ < pointI.UpperZone && valJ > pointI.LowerZone)
                    {
                        @group.Add(pointJ.CurrentPrice);
                        newIndex = j;
                    }
                    else
                        break;
                }

                i = newIndex;
                extremaGroups.Add(@group);
            }

            extremaGroups = extremaGroups.Where(g => g.Count > minCount).ToList();
            return extremaGroups;
        }

        private static List<Extrema> FilterBrokenLimits(List<Extrema> extremePoints, ExtremaType extremaType, double offsetPercent)
        {
            extremePoints.Reverse();

            var mostExtrema = extremaType == ExtremaType.Minimum ? float.MaxValue : float.MinValue;

            var activePoints = new List<Extrema>();

            foreach (var point in extremePoints)
            {
                var val = point.CurrentPrice.Close;

                if (!activePoints.Any())
                {
                    activePoints.Add(point);
                    mostExtrema = val;
                }
                else
                {
                    var shouldCheckOffset = false;

                    switch (extremaType)
                    {
                        case ExtremaType.Minimum:
                            {
                                // Even if bigger, check if is in offset
                                if (mostExtrema < val)
                                    shouldCheckOffset = true;
                                break;
                            }
                        case ExtremaType.Maximum:
                            {
                                // Even if smaller, check if is in offset
                                if (mostExtrema > val)
                                    shouldCheckOffset = true;
                                break;
                            }
                        default:
                            throw new ArgumentOutOfRangeException(nameof(extremaType), extremaType, null);
                    }

                    if (shouldCheckOffset)
                    {
                        if (IsInOffsetRange(offsetPercent, val, mostExtrema, extremaType))
                            activePoints.Add(point);
                        continue;
                    }

                    mostExtrema = val;
                    activePoints.Add(point);
                }
            }

            return activePoints;
        }

        private static bool IsInOffsetRange(double offsetPercent, float currentValue, float extremaValue, ExtremaType extremaType)
        {
            switch (extremaType)
            {
                case ExtremaType.Minimum:
                    return currentValue < (extremaValue + (extremaValue * offsetPercent) / 100);
                case ExtremaType.Maximum:
                    return currentValue > (extremaValue - (extremaValue + offsetPercent) / 100);
                default:
                    throw new ArgumentOutOfRangeException(nameof(extremaType), extremaType, null);
            }
        }

        private static List<Extrema> GetExtremePoints(List<Price> prices, ExtremaType extremePoint, double offsetPercent)
        {
            var potentials = new List<Price>();

            for (var i = 0; i < prices.Count - 1; i++)
            {
                if (i == 0)
                    continue;

                var yesterday = prices[i - 1].Close;
                var today = prices[i].Close;
                var tomorrow = prices[i + 1].Close;

                switch (extremePoint)
                {
                    case ExtremaType.Minimum:
                        if (today.IsMinima(yesterday, tomorrow))
                            potentials.Add(prices[i]);
                        break;
                    case ExtremaType.Maximum:
                        if (today.IsMaxima(yesterday, tomorrow))
                            potentials.Add(prices[i]);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(extremePoint), extremePoint, null);
                }
            }

            var extremePoints = potentials.Select(p => new Extrema(p, offsetPercent)).ToList();
            return extremePoints;
        }

        private static bool IsIncluded(LinkedList<DateTime> childrenOfB, Extrema extrema)
        {
            var extremaPrices = extrema.Prices.Select(c => c.StartTime).ToList();

            return childrenOfB.All(dateTime => extremaPrices.Contains(dateTime));
        }

        public Dictionary<DayOfWeek, MomentumCount> GetDaysMomentum(List<Price> prices)
        {
            var momentum = new Dictionary<DayOfWeek, MomentumCount>
            {
                {DayOfWeek.Monday, new MomentumCount()},
                {DayOfWeek.Tuesday, new MomentumCount()},
                {DayOfWeek.Wednesday, new MomentumCount()},
                {DayOfWeek.Thursday, new MomentumCount()},
                {DayOfWeek.Friday, new MomentumCount()},
            };

            for (var i = 1; i < prices.Count; i++)
            {
                var prevPrice = prices[i - 1];
                var currentPrice = prices[i];

                var day = currentPrice.StartTime.DayOfWeek;

                var revenue = 0d;

                if (currentPrice.Close > prevPrice.Close)
                {
                    momentum[day].UpCount++;
                    revenue = (currentPrice.Close - prevPrice.Close) / prevPrice.Close * 100;
                }
                    
                else if (currentPrice.Close < prevPrice.Close)
                {
                    momentum[day].DownCount++;
                    revenue = -(prevPrice.Close - currentPrice.Close) / prevPrice.Close * 100;
                }


                momentum[day].TotalRevenue += revenue;
            }

            return momentum;
        }
    }
}
