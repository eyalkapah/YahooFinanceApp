using System.Collections.Generic;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class EarningsTrend
    {
        public IEnumerable<Trend1> Trend { get; set; }

        public int MaxAge { get; set; }
    }
}
