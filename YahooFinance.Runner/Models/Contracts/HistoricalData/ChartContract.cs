using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.HistoricalData
{
    public class ChartContract
    {
        [JsonPropertyName("result")]
        public IEnumerable<ResultContract> Result { get; set; }

        [JsonPropertyName("error")]
        public object Error { get; set; }
    }
}