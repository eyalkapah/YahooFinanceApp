using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class CashFlowStatementHistoryContract
    {
        [JsonPropertyName("cashflowStatements")]
        public CashFlowStatementContract[] CashFlowStatements { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}