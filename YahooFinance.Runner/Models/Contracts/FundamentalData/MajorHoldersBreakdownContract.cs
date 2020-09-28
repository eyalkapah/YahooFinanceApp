using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class MajorHoldersBreakdownContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("insidersPercentHeld")]
        public ShortenedValueContract InsidersPercentHeld { get; set; }

        [JsonPropertyName("institutionsPercentHeld")]
        public ShortenedValueContract InstitutionsPercentHeld { get; set; }

        [JsonPropertyName("institutionsFloatPercentHeld")]
        public ShortenedValueContract InstitutionsFloatPercentHeld { get; set; }

        [JsonPropertyName("institutionsCount")]
        public ValueContract InstitutionsCount { get; set; }
    }
}