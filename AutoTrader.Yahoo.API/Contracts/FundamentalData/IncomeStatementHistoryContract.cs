using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class IncomeStatementHistoryContract
    {
        [JsonPropertyName("incomeStatementHistory")]
        public IncomeStatementHistory1Contract[] IncomeStatementHistory { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}