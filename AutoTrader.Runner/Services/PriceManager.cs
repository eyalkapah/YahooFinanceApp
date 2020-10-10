using System;
using System.Collections.Generic;
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

        public List<FocusPoint> CalculateSupportPoints(List<Price> prices, double offsetPercent)
        {
            var potentials = new List<Price>();

            for (var i = 0; i < prices.Count - 1; i++)
            {
                if (i == 0)
                    continue;

                var yesterday = prices[i - 1].Close;
                var today = prices[i].Close;
                var tomorrow = prices[i + 1].Close;

                if (yesterday > today && today < tomorrow)
                    potentials.Add(prices[i]);
            }

            var limitPoints = potentials.Select(p => new FocusPoint(p, offsetPercent)).ToList();

            foreach (var limitPoint in limitPoints)
            {
                foreach (var potential in potentials.Where(c => c.StartTime < limitPoint.CurrentPrice.StartTime))
                {
                    if (limitPoint.CurrentPrice.StartTime == potential.StartTime)
                        continue;

                    if (potential.Close > limitPoint.LowerZone && potential.Close < limitPoint.UpperZone)
                        limitPoint.Prices.Add(potential);
                }
            }

            return limitPoints;
        }
    }
}
