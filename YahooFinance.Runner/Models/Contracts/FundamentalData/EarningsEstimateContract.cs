using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class EarningsEstimateContract
    {
        [JsonPropertyName("avg")]
        public ShortenedValueContract Avg { get; set; }

        [JsonPropertyName("low")]
        public ShortenedValueContract Low { get; set; }

        [JsonPropertyName("high")]
        public ShortenedValueContract High { get; set; }

        [JsonPropertyName("yearAgoEps")]
        public ShortenedValueContract YearAgoEps { get; set; }

        [JsonPropertyName("numberOfAnalysts")]
        public ValueContract NumberOfAnalysts { get; set; }

        [JsonPropertyName("growth")]
        public ShortenedValueContract Growth { get; set; }
    }
}