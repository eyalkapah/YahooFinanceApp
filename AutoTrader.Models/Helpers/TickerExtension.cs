using AutoTrader.Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace AutoTrader.Models.Helpers
{
    public static class TickerExtension
    {
        public static IEnumerable<IGrouping<string, Ticker>> GroupBySymbol(this IEnumerable<Ticker> tickers) =>
            tickers.GroupBy(c => c.Symbol);

        public static string GetSector(this IEnumerable<Ticker> tickers, string symbol) =>
            tickers.First(c => c.Symbol.Equals(symbol)).Sector;
    }
}
