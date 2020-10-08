using System;
using System.Collections.Generic;
using System.Linq;
using YahooFinance.Runner.Models;
using YahooFinance.Runner.Models.HistoricalData;

namespace YahooFinance.Runner.Helpers
{
    public static class ProfitExtensions
    {
        public static IEnumerable<Profit> Sort(this IEnumerable<Profit> profits, bool ascending = true)
        {
            return !@ascending
                ? profits.OrderByDescending(c => c.ProfitPercentage)
                : profits.OrderBy(c => c.ProfitPercentage);
        }

        public static double Average(this IEnumerable<Profit> profits)
        {
            var enumerable = profits as Profit[] ?? profits.ToArray();

            if (!enumerable.Any())
                return 0;

            return Math.Round(enumerable.Sum(c => c.ProfitPercentage) /
                enumerable.Count(), 2);
        }

        public static double CalculateProfitPercentage(this IGrouping<string, Price> groupedPrice) =>
            Math.Round(((groupedPrice.Last().Close - groupedPrice.First().Open) / groupedPrice.First().Open) * 100, 2);

        public static List<string> GetTopProfitableStocks(this IEnumerable<Profit> profits, int numOfStocks) =>
            profits.OrderByDescending(c => c.ProfitPercentage)
                .Take(numOfStocks)
                .Select(c => c.Symbol).ToList();

        public static double Average(this IEnumerable<Profit> profits, IEnumerable<string> stocks)
            => profits.Where(c => stocks.Contains(c.Symbol)).Average();
    }
}
