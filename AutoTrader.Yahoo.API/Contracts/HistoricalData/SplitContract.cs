using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.HistoricalData
{
    public class SplitContract
    {
        [JsonPropertyName("splitRatio")]
        public string SplitRatio { get; set; }

        [JsonPropertyName("numerator")]
        public int Numerator { get; set; }

        [JsonPropertyName("denominator")]
        public int Denominator { get; set; }

        [JsonPropertyName("date")]
        public long Date { get; set; }
    }
}
