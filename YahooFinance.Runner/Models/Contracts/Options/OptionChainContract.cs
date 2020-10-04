using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.Options
{
    public class OptionChainContract
    {
        [JsonPropertyName("result")]
        public ResultContract[] Result { get; set; }

        [JsonPropertyName("error")]
        public object Error { get; set; }
    }
}