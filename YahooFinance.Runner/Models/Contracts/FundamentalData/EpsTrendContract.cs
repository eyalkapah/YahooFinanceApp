using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class EpsTrendContract
    {
        [JsonPropertyName("current")]
        public ShortenedValueContract Current { get; set; }

        [JsonPropertyName("_7daysAgo")]
        public ShortenedValueContract _7daysAgo { get; set; }

        [JsonPropertyName("_30daysAgo")]
        public ShortenedValueContract _30daysAgo { get; set; }

        [JsonPropertyName("_60daysAgo")]
        public ShortenedValueContract _60daysAgo { get; set; }

        [JsonPropertyName("_90daysAgo")]
        public ShortenedValueContract _90daysAgo { get; set; }
    }
}