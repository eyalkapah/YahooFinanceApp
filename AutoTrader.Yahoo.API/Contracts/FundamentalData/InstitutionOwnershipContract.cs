using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class InstitutionOwnershipContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("ownershipList")]
        public OwnershipList1Contract[] OwnershipList { get; set; }
    }
}