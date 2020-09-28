using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class ShortenedValueContract
    {
        [JsonPropertyName("raw")]
        public int Raw { get; set; }

        [JsonPropertyName("fmt")]
        public string Fmt { get; set; }
    }
}