using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class IncomeStatementHistoryQuarterlyContract
    {
        [JsonPropertyName("incomeStatementHistory")]
        public IncomStatementHistory2Contract[] IncomeStatementHistory { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}