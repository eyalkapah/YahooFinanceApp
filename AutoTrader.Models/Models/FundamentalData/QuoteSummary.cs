using System.Collections.Generic;

namespace AutoTrader.Models.Models.FundamentalData
{
    public class QuoteSummary
    {
        public IEnumerable<Result> Result { get; set; }

        public object Error { get; set; }
    }
}
