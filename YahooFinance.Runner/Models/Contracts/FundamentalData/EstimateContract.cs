using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class EstimateContract
    {
        [JsonPropertyName("period")]
        public string Period { get; set; }

        [JsonPropertyName("growth")]
        public ShortenedValueContract Growth { get; set; }
    }
}