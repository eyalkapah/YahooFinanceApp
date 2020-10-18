using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoTrader.Models.Enums;
using AutoTrader.Models.Helpers;
using AutoTrader.Models.Interfaces;
using AutoTrader.Models.Models;
using AutoTrader.Models.Models.HistoricalData;

namespace AutoTrader.Runner.Services
{
    public class PriceManager
    {
        private readonly IStockDataService _service;

        public PriceManager(IStockDataService service)
        {
            _service = service;
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

        public List<ExtremaPoint> CalculateExtremePoints(List<Price> prices, ExtremaType extremePoint, double offsetPercent)
        {
            var potentials = new List<Price>();

            // Get extreme points
            var extremePoints = GetExtremePoints(prices, extremePoint, offsetPercent, potentials);


            foreach (var extrema in extremePoints)
            {
                foreach (var potential in potentials.Where(c => c.StartTime < extrema.CurrentPrice.StartTime))
                {
                    if (extrema.CurrentPrice.StartTime == potential.StartTime)
                        continue;

                    if (potential.Close.IsBetween(extrema.LowerZone, extrema.UpperZone))
                        extrema.Prices.Add(potential);
                }
            }

            extremePoints = extremePoints.Where(c => c.Prices.Any()).ToList();

            var list = new List<ExtremaPoint>();
            var pointsToKeep = new HashSet<DateTime>();
            var pointsToCheck = new Dictionary<DateTime, LinkedList<DateTime>>();

            foreach (var extrema in extremePoints)
            {
                pointsToCheck[extrema.CurrentPrice.StartTime] = new LinkedList<DateTime>(extrema.Prices.Select(p => p.StartTime));
            }

            // Merge points
            foreach (var (startTime, childrenOfB) in pointsToCheck.Reverse())
            {
                if (!pointsToKeep.Any())
                    pointsToKeep.Add(startTime);
                else
                {
                    var pointsWithB = extremePoints.Where(c => c.Prices.Any(c => c.StartTime == startTime));

                    var shouldInclude = true;

                    foreach (var extrema in pointsWithB)
                    {
                        if (!shouldInclude)
                            break;

                        if (!pointsToKeep.Contains(extrema.CurrentPrice.StartTime))
                            continue;

                        var isIncluded = IsIncluded(childrenOfB, extrema);

                        if (isIncluded)
                            shouldInclude = false;
                    }

                    if (shouldInclude)
                        pointsToKeep.Add(startTime);
                }
            }

            var l = extremePoints.Where(c => pointsToKeep.Contains(c.CurrentPrice.StartTime)).ToList();


            foreach (var extrema in l)
            {
                prices = extrema.Prices.Concat(new List<Price> { extrema.CurrentPrice }).ToList();
                var min = prices.Select(c => c.Close).Min();
                var max = prices.Select(c => c.Close).Max();

                list.Add(new ExtremaPoint
                {
                    Prices = prices,
                    Min = min,
                    Max = max,
                    Avg = (min + max) / 2
                });
            }

            foreach (var p in list)
            {
                Debug.WriteLine($"Min: {p.Min}");
                Debug.WriteLine($"Max: {p.Max}");
                Debug.WriteLine($"Avg: {p.Avg}");

                foreach (var pPrice in p.Prices)
                {
                    Debug.WriteLine($"\t{pPrice.StartTime}");
                }
            }

            list.Reverse();

            var newList = new List<ExtremaPoint>();
            var containedIds = new List<Guid>();

            foreach (var pl in list)
            {
                var avg = pl.Avg;
                var offset = (avg * offsetPercent / 100);

                var upperLimit = avg + offset;
                var lowerLimit = avg - offset;

                var extremePointsInOffset = list.Where(c => c.Avg > lowerLimit && c.Avg < upperLimit).ToList();

                if (extremePointsInOffset.Count() == 1 && containedIds.Contains(extremePointsInOffset.First().Id))
                    continue;
                else
                {
                    containedIds.AddRange(extremePointsInOffset.Select(c => c.Id));

                    var priceList = new HashSet<Price>();

                    foreach (var extremaPoint in extremePointsInOffset)
                    {
                        foreach (var extremaPointPrice in extremaPoint.Prices)
                        {
                            if (priceList.All(c => c.StartTime != extremaPointPrice.StartTime))
                                priceList.Add(extremaPointPrice);
                        }
                    }

                    newList.Add(new ExtremaPoint
                    {
                        Avg = extremePointsInOffset.Sum(c => c.Avg) / extremePointsInOffset.Count,
                        Min = extremePointsInOffset.Min(c => c.Min),
                        Max = extremePointsInOffset.Max(c => c.Max),
                        Prices = priceList.ToList()

                    });
                }
            }
            return newList;
        }

        private static List<Extrema> GetExtremePoints(List<Price> prices, ExtremaType extremePoint, double offsetPercent, List<Price> potentials)
        {
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
    }
}
