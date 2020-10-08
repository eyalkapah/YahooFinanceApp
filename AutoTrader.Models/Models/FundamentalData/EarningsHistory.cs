using System.Collections.Generic;

namespace AutoTrader.Models.Models.FundamentalData
{
    public class EarningsHistory
    {
        public IEnumerable<History1> History { get; set; }

        public int MaxAge { get; set; }
    }
}
