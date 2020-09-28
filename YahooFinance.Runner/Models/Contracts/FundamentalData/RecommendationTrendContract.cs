using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class RecommendationTrendContract
    {
        [JsonPropertyName("trend")]
        public TrendContract[] Trend { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}