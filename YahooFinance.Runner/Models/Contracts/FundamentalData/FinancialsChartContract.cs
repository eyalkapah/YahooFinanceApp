using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class FinancialsChartContract
    {
        [JsonPropertyName("yearly")]
        public YearlyContract[] Yearly { get; set; }

        [JsonPropertyName("quarterly")]
        public Quarterly1Contract[] Quarterly { get; set; }
    }
}