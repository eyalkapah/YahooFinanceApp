using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.HistoricalData
{
    public class ResultContract 
    {
        [JsonPropertyName("meta")]
        public MetaContract Meta { get; set; }

        [JsonPropertyName("timestamp")]
        public IEnumerable<int> Timestamp { get; set; }

        [JsonPropertyName("indicators")]
        public IndicatorsContract Indicators { get; set; }
    }
}