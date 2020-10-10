using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoTrader.Models.Models;

namespace AutoTrader.Models.Helpers
{
    public static class TickersExtensions
    {
        public static Ticker GetBySymbol(this IEnumerable<Ticker> tickers, string symbol) =>
            tickers.FirstOrDefault(c => c.Symbol.Equals(symbol));
    }
}
