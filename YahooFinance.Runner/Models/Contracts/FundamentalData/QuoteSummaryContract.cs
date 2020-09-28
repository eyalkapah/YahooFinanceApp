using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class QuoteSummaryContract
    {
        [JsonPropertyName("result")]
        public IEnumerable<ResultContract> Result { get; set; }

        [JsonPropertyName("error")]
        public object Error { get; set; }
    }
}