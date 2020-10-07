﻿using System;
using System.Collections.Generic;
using System.Linq;
using YahooFinance.Runner.Helpers;
using YahooFinance.Runner.Models;
using YahooFinance.Runner.Models.HistoricalData;

namespace YahooFinance.Runner.Services
{
    public class PriceService
    {
        public static IEnumerable<string> GetStockNames(IEnumerable<Price> prices) => prices.Select(p => p.Symbol).Distinct();

        public static List<Profit> CalculateProfits(IEnumerable<Price> prices)
        {
            // Group all prices by symbol
            var groupedList = prices.GroupBy(c => c.Symbol);

            // Calculate profit for each symbol
            return groupedList.Select(grouped => new Profit
            {
                Symbol = grouped.Key,
                StartTime = grouped.First().StartTime,
                EndTime = grouped.Last().StartTime,
                ProfitPercentage = grouped.CalculateProfitPercentage()
            }).ToList();
        }

        public static MomentumDetail CalculateMomentum(List<Price> prices, DateTime cutTime, int numOfStocks)
        {
            prices = prices.SortByStartTime();

            if (numOfStocks > GetStockNames(prices).Count())
                throw new ArgumentException("numOfStocks cannot be bigger than total stock number");

            var trainPeriod = prices.TrimUntil(cutTime);

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

        public static List<MomentumDetail> SlidingWindow(List<Price> prices, int trainDays, int testDays, int numOfStocks)
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
    }
}