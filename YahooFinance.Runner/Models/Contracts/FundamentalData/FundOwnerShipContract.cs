using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class FundOwnerShipContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("ownershipList")]
        public OwnerShipListContract[] OwnershipList { get; set; }
    }
}