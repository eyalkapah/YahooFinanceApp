using System.Collections.Generic;

namespace AutoTrader.Models.Models.FundamentalData
{
    public class SecFilings
    {
        public IEnumerable<Filing> Filings { get; set; }

        public int MaxAge { get; set; }
    }
}
