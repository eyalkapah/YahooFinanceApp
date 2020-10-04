using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.Options
{
    public class OptionContract
    {
        [JsonPropertyName("expirationDate")]
        public int ExpirationDate { get; set; }

        [JsonPropertyName("hasMiniOptions")]
        public bool HasMiniOptions { get; set; }

        [JsonPropertyName("calls")]
        public CallContract[] Calls { get; set; }

        [JsonPropertyName("puts")]
        public PutContract[] Puts { get; set; }
    }
}