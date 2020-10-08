using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class BalanceSheetHistoryContract
    {
        [JsonPropertyName("balanceSheetStatements")]
        public BalanceSheetStatementContract[] BalanceSheetStatements { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}