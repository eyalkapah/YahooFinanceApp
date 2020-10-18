using System;
using System.Collections.Generic;
using System.Linq;
using AutoTrader.Models.Models.HistoricalData;

namespace AutoTrader.Models.Helpers
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

        public static void AddPrice(this ICollection<Price> prices, DateTime date, string symbol, string open, string high, string low,
            string close, string volume, string dividends, string splits)
        {
            if (string.IsNullOrWhiteSpace(symbol) || string.IsNullOrWhiteSpace(open) ||
                string.IsNullOrWhiteSpace(high) || string.IsNullOrWhiteSpace(low)
                || string.IsNullOrWhiteSpace(close) || string.IsNullOrWhiteSpace(volume))
                return;

            prices.Add(new Price
            {
                StartTime = date,
                Symbol = symbol,
                Open = Convert.ToSingle(open),
                High = Convert.ToSingle(high),
                Low = Convert.ToSingle(low),
                Close = Convert.ToSingle(close),
                Volume = Convert.ToDouble(volume),
                Dividends = Convert.ToSingle(dividends),
                StockSplits = Convert.ToInt32(splits)
            });
        }


    }
}
