using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class IndexTrendContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("peRatio")]
        public ShortenedValueContract PeRatio { get; set; }

        [JsonPropertyName("pegRatio")]
        public ShortenedValueContract PegRatio { get; set; }

        [JsonPropertyName("estimates")]
        public EstimateContract[] Estimates { get; set; }
    }
}