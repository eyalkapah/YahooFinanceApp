using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YahooFinance.Runner.Models;
using YahooFinance.Runner.Models.HistoricalData;

namespace YahooFinance.Runner.Helpers
{
    public static class PricesExtensions
    {
        public static IEnumerable<string> GetStockNames(this IEnumerable<Price> prices) => prices.Select(p => p.Symbol).Distinct();

        public static IEnumerable<Returns> CalculateReturns(this IEnumerable<Price> prices)
        {
            var groupedList = prices.GroupBy(c => c.Symbol);

            var list = new List<Returns>();

            foreach (var grouped in groupedList)
            {
                list.Add(new Returns
                {
                    Symbol = grouped.Key,
                    StartTime = grouped.First().StartTime,
                    EndTime = grouped.Last().StartTime,
                    ReturnPercentage =
                        Math.Round(((grouped.Last().Close - grouped.First().Open) / grouped.First().Open) * 100, 2)
                });
            }

            return list;
        }

        public static MomentumDetail CalculateMomentum(this IEnumerable<Price> prices, DateTime cutTime, int numOfStocks)
        {
            if (numOfStocks > prices.Count())
                throw new ArgumentException("numOfStocks must be either equal or smaller than total price count");

            prices = prices.OrderBy(c => c.StartTime);

            var trainPrices = prices.Where(c => c.StartTime < cutTime);

            var trainReturns = trainPrices.CalculateReturns();

            var testPrices = prices.Where(c => c.StartTime > cutTime);

            var testReturns = testPrices.CalculateReturns();

            var stocksToBuy = trainReturns.OrderByDescending(c => c.ReturnPercentage).Take(numOfStocks).Select(c => c.Symbol);

            var selectedStocksAverage = testReturns.Where(c => stocksToBuy.Contains(c.Symbol)).Average();

            return new MomentumDetail
            {
                AllSymbols = trainPrices.GetStockNames().Concat(testPrices.GetStockNames()).Distinct(),
                TrainAverage = trainReturns.Average(),
                TestAverage = testReturns.Average(),
                StocksToBuy = stocksToBuy,
                StocksToBuyAverage = selectedStocksAverage
            };
        }

        public static Task SlidingWindow(this IEnumerable<Price> prices, DateTime cutTime, int slidingInterval)
        {

        }
    }
}
