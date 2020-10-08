using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class Trend1Contract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("period")]
        public string Period { get; set; }

        [JsonPropertyName("endDate")]
        public string EndDate { get; set; }

        [JsonPropertyName("growth")]
        public ShortenedValueContract Growth { get; set; }

        [JsonPropertyName("earningsEstimate")]
        public EarningsEstimateContract EarningsEstimate { get; set; }

        [JsonPropertyName("revenueEstimate")]
        public RevenueEstimateContract RevenueEstimate { get; set; }

        [JsonPropertyName("epsTrend")]
        public EpsTrendContract EpsTrend { get; set; }

        [JsonPropertyName("epsRevisions")]
        public EpsRevisionsContract EpsRevisions { get; set; }
    }
}