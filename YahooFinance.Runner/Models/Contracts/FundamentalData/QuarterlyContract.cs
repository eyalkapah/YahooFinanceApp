using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
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