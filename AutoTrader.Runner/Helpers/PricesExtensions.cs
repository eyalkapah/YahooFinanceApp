using System;
using System.Collections.Generic;
using System.Linq;
using YahooFinance.Runner.Models.HistoricalData;

namespace YahooFinance.Runner.Helpers
{
    public static class PricesExtensions
    {
        public static IEnumerable<string> GetStockNames(this IEnumerable<Price> prices) => prices.Select(p => p.Symbol).Distinct();

        public static List<Price> SortByStartTime(this IEnumerable<Price> prices, bool ascending = true)
        {
            return ascending
                ? prices.OrderBy(c => c.StartTime).ToList()
                : prices.OrderByDescending(c => c.StartTime).ToList();
        }

        public static List<Price> TrimUntil(this IEnumerable<Price> prices, DateTime cutDate, bool includeEqual = false) 
            => includeEqual 
                ? prices.Where(c => c.StartTime <= cutDate).ToList() 
                : prices.Where(c => c.StartTime < cutDate).ToList();

        public static List<Price> TrimFrom(this IEnumerable<Price> prices, DateTime cutDate, bool includeEqual = false)
            => includeEqual
                ? prices.Where(c => c.StartTime >= cutDate).ToList()
                : prices.Where(c => c.StartTime > cutDate).ToList();

        public static IEnumerable<string> ConcatStockNames(this List<Price> list1, List<Price> list2)
            => list1.GetStockNames().Concat(list2.GetStockNames()).Distinct();

        public static int DaysCount(this List<Price> prices)
        {
            prices = prices.SortByStartTime();
            return (prices.Last().StartTime - prices.First().StartTime).Days;
        } 

        public static List<Price> BetweenDates(this List<Price> prices, DateTime startTime, DateTime endTime)
            => prices.Where(c => c.StartTime >= startTime && c.StartTime <= endTime).ToList();

        public static IEnumerable<IGrouping<string, Price>> GroupByStock(this IEnumerable<Price> prices) =>
            prices.GroupBy(c => c.Symbol);
    }
}
