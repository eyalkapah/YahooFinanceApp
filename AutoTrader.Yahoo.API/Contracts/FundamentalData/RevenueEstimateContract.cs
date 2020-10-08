using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class RevenueEstimateContract
    {
        [JsonPropertyName("avg")]
        public ValueContract Avg { get; set; }

        [JsonPropertyName("low")]
        public ValueContract Low { get; set; }

        [JsonPropertyName("high")]
        public ValueContract High { get; set; }

        [JsonPropertyName("numberOfAnalysts")]
        public ValueContract NumberOfAnalysts { get; set; }

        [JsonPropertyName("yearAgoRevenue")]
        public ValueContract YearAgoRevenue { get; set; }

        [JsonPropertyName("growth")]
        public ShortenedValueContract Growth { get; set; }
    }
}