using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class ValueContract
    {
        [JsonPropertyName("raw")]
        public int Raw { get; set; }

        [JsonPropertyName("fmt")]
        public string Fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string LongFmt { get; set; }
    }
}