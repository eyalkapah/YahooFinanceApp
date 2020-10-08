using System.Collections.Generic;

namespace AutoTrader.Models.Models.FundamentalData
{
    public class UpgradeDowngradeHistory
    {
        public IEnumerable<History> History { get; set; }

        public int MaxAge { get; set; }
    }
}
