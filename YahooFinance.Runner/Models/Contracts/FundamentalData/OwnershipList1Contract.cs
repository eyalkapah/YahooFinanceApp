using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class OwnershipList1Contract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("reportDate")]
        public ShortenedValueContract ReportDate { get; set; }

        [JsonPropertyName("organization")]
        public string Organization { get; set; }

        [JsonPropertyName("pctHeld")]
        public ShortenedValueContract PctHeld { get; set; }

        [JsonPropertyName("position")]
        public ValueContract Position { get; set; }

        [JsonPropertyName("value")]
        public ValueContract Value { get; set; }
    }
}