using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.Options
{
    public class ResultContract
    {
        [JsonPropertyName("underlyingSymbol")]
        public string UnderlyingSymbol { get; set; }

        [JsonPropertyName("expirationDates")]
        public int[] ExpirationDates { get; set; }

        [JsonPropertyName("strikes")]
        public float[] Strikes { get; set; }

        [JsonPropertyName("hasMiniOptions")]
        public bool HasMiniOptions { get; set; }

        [JsonPropertyName("quote")]
        public QuoteContract Quote { get; set; }

        [JsonPropertyName("options")]
        public OptionContract[] Options { get; set; }
    }
}