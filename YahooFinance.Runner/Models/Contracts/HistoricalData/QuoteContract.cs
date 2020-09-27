using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.HistoricalData
{
    public class QuoteContract
    {
        [JsonPropertyName("volume")]
        public IEnumerable<double> Volume { get; set; }

        [JsonPropertyName("open")]
        public IEnumerable<float> Open { get; set; }

        [JsonPropertyName("low")]
        public IEnumerable<float> Low { get; set; }

        [JsonPropertyName("high")]
        public IEnumerable<float> High { get; set; }

        [JsonPropertyName("close")]
        public IEnumerable<float> Close { get; set; }
    }
}