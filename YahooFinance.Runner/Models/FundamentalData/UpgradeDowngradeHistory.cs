using System.Collections.Generic;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class UpgradeDowngradeHistory
    {
        public IEnumerable<History> History { get; set; }

        public int MaxAge { get; set; }
    }
}
