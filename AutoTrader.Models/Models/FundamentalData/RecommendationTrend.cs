using System.Collections.Generic;

namespace AutoTrader.Models.Models.FundamentalData
{
    public class RecommendationTrend
    {
        public IEnumerable<Trend> Trend { get; set; }

        public int MaxAge { get; set; }
    }
}
