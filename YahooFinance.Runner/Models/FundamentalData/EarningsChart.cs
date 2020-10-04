using System.Collections.Generic;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class EarningsChart
    {
        public IEnumerable<Quarterly> Quarterly { get; set; }

        public ShortenedValue CurrentQuarterEstimate { get; set; }

        public string CurrentQuarterEstimateDate { get; set; }

        public int CurrentQuarterEstimateYear { get; set; }

        public IEnumerable<ShortenedValue> EarningsDate { get; set; }
    }
}
