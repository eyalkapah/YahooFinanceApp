using System.Collections.Generic;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class QuoteSummary
    {
        public IEnumerable<Result> Result { get; set; }

        public object Error { get; set; }
    }
}
