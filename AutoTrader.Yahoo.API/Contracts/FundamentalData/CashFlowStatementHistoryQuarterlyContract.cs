using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class CashFlowStatementHistoryQuarterlyContract
    {
        [JsonPropertyName("cashflowStatements")]
        public Cashflowstatement1[] CashflowStatements { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}