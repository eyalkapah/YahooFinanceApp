using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class History1Contract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("epsActual")]
        public ShortenedValueContract EpsActual { get; set; }

        [JsonPropertyName("epsEstimate")]
        public ShortenedValueContract EpsEstimate { get; set; }

        [JsonPropertyName("epsDifference")]
        public ShortenedValueContract EpsDifference { get; set; }

        [JsonPropertyName("surprisePercent")]
        public ShortenedValueContract SurprisePercent { get; set; }

        [JsonPropertyName("quarter")]
        public ShortenedValueContract Quarter { get; set; }

        [JsonPropertyName("period")]
        public string Period { get; set; }
    }
}