using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class ShortenedValueContract
    {
        [JsonPropertyName("raw")]
        public decimal Raw { get; set; }

        [JsonPropertyName("fmt")]
        public string Fmt { get; set; }
    }
}