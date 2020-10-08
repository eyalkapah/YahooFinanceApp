using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class RecommendationTrendContract
    {
        [JsonPropertyName("trend")]
        public TrendContract[] Trend { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}