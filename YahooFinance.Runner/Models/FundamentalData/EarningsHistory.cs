using System.Collections.Generic;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class EarningsHistory
    {
        public IEnumerable<History1> History { get; set; }

        public int MaxAge { get; set; }
    }
}
