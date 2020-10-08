using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class EarningsChartContract
    {
        [JsonPropertyName("quarterly")]
        public QuarterlyContract[] Quarterly { get; set; }

        [JsonPropertyName("currentQuarterEstimate")]
        public ShortenedValueContract CurrentQuarterEstimate { get; set; }

        [JsonPropertyName("currentQuarterEstimateDate")]
        public string CurrentQuarterEstimateDate { get; set; }

        [JsonPropertyName("currentQuarterEstimateYear")]
        public int CurrentQuarterEstimateYear { get; set; }

        [JsonPropertyName("earningsDate")]
        public ShortenedValueContract[] EarningsDate { get; set; }
    }
}