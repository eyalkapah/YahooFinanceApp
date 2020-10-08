using System.Collections.Generic;

namespace AutoTrader.Models.Models.FundamentalData
{
    public class EarningsTrend
    {
        public IEnumerable<Trend1> Trend { get; set; }

        public int MaxAge { get; set; }
    }
}
