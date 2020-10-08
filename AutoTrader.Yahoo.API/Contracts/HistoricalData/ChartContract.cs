using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.HistoricalData
{
    public class ChartContract
    {
        [JsonPropertyName("result")]
        public IEnumerable<ResultContract> Result { get; set; }

        [JsonPropertyName("error")]
        public object Error { get; set; }
    }
}