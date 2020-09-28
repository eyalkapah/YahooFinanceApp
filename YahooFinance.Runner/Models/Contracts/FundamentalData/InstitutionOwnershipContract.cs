using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class InstitutionOwnershipContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("ownershipList")]
        public OwnershipList1Contract[] OwnershipList { get; set; }
    }
}