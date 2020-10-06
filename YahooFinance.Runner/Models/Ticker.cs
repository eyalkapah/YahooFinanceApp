using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
