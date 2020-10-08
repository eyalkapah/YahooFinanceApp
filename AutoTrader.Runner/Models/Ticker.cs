using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinance.Runner.Models.HistoricalData;

namespace YahooFinance.Runner.Models
{
    public class Ticker
    {
        public string Symbol { get; }

        public Ticker(string symbol)
        {
            Symbol = symbol;
        }
    }
}
