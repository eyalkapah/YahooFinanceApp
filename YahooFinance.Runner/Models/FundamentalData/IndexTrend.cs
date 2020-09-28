using System.Collections.Generic;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class IndexTrend
    {
        public int MaxAge { get; set; }

        public string Symbol { get; set; }

        public ShortenedValue PeRatio { get; set; }

        public ShortenedValue PegRatio { get; set; }

        public IEnumerable<Estimate> Estimates { get; set; }
    }
}
