using System.Collections.Generic;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class Earnings
    {
        public IEnumerable<ShortenedValue> EarningsDate { get; set; }

        public ShortenedValue EarningsAverage { get; set; }

        public ShortenedValue EarningsLow { get; set; }

        public ShortenedValue EarningsHigh { get; set; }

        public Value RevenueAverage { get; set; }

        public Value RevenueLow { get; set; }

        public Value RevenueHigh { get; set; }
    }
}
