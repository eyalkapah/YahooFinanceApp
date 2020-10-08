using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class QuarterlyContract
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("actual")]
        public ShortenedValueContract Actual { get; set; }

        [JsonPropertyName("estimate")]
        public ShortenedValueContract Estimate { get; set; }
    }
}