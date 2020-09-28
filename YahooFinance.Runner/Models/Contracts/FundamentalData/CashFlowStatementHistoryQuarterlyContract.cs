using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class CashFlowStatementHistoryQuarterlyContract
    {
        [JsonPropertyName("cashflowStatements")]
        public Cashflowstatement1[] CashflowStatements { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}