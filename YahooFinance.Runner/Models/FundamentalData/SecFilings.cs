using System.Collections.Generic;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class SecFilings
    {
        public IEnumerable<Filing> Filings { get; set; }

        public int MaxAge { get; set; }
    }
}
