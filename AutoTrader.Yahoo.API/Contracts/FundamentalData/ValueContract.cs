using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class ValueContract
    {
        [JsonPropertyName("raw")]
        public long Raw { get; set; }

        [JsonPropertyName("fmt")]
        public string Fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string LongFmt { get; set; }
    }
}