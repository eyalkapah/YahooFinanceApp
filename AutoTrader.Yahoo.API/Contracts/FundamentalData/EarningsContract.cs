using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class EarningsContract
    {
        [JsonPropertyName("earningsDate")]
        public ShortenedValueContract[] EarningsDate { get; set; }

        [JsonPropertyName("earningsAverage")]
        public ShortenedValueContract EarningsAverage { get; set; }

        [JsonPropertyName("earningsLow")]
        public ShortenedValueContract EarningsLow { get; set; }

        [JsonPropertyName("earningsHigh")]
        public ShortenedValueContract EarningsHigh { get; set; }

        [JsonPropertyName("revenueAverage")]
        public ValueContract RevenueAverage { get; set; }

        [JsonPropertyName("revenueLow")]
        public ValueContract RevenueLow { get; set; }

        [JsonPropertyName("revenueHigh")]
        public ValueContract RevenueHigh { get; set; }
    }
}