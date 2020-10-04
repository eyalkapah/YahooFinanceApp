using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.Options
{

    public class OptionsContract
    {
        [JsonPropertyName("optionChain")]
        public OptionChainContract OptionChain { get; set; }
    }
}
