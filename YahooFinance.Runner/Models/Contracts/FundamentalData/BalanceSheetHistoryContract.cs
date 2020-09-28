using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class BalanceSheetHistoryContract
    {
        [JsonPropertyName("balanceSheetStatements")]
        public BalanceSheetStatementContract[] BalanceSheetStatements { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}