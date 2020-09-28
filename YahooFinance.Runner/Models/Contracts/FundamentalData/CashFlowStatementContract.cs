using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class CashFlowStatementContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("endDate")]
        public ShortenedValueContract EndDate { get; set; }

        [JsonPropertyName("netIncome")]
        public ValueContract NetIncome { get; set; }

        [JsonPropertyName("depreciation")]
        public ValueContract Depreciation { get; set; }

        [JsonPropertyName("changeToNetincome")]
        public ValueContract ChangeToNetIncome { get; set; }

        [JsonPropertyName("changeToAccountReceivables")]
        public ValueContract ChangeToAccountReceivables { get; set; }

        [JsonPropertyName("changeToLiabilities")]
        public ValueContract ChangeToLiabilities { get; set; }

        [JsonPropertyName("changeToInventory")]
        public ValueContract ChangeToInventory { get; set; }

        [JsonPropertyName("changeToOperatingActivities")]
        public ValueContract ChangeToOperatingActivities { get; set; }

        [JsonPropertyName("totalCashFromOperatingActivities")]
        public ValueContract TotalCashFromOperatingActivities { get; set; }

        [JsonPropertyName("capitalExpenditures")]
        public ValueContract CapitalExpenditures { get; set; }

        [JsonPropertyName("investments")]
        public ValueContract Investments { get; set; }

        [JsonPropertyName("otherCashflowsFromInvestingActivities")]
        public ValueContract OtherCashFlowsFromInvestingActivities { get; set; }

        [JsonPropertyName("totalCashflowsFromInvestingActivities")]
        public ValueContract TotalCashFlowsFromInvestingActivities { get; set; }

        [JsonPropertyName("dividendsPaid")]
        public ValueContract DividendsPaid { get; set; }

        [JsonPropertyName("netBorrowings")]
        public ValueContract NetBorrowings { get; set; }

        [JsonPropertyName("otherCashflowsFromFinancingActivities")]
        public ValueContract OtherCashFlowsFromFinancingActivities { get; set; }

        [JsonPropertyName("totalCashFromFinancingActivities")]
        public ValueContract TotalCashFromFinancingActivities { get; set; }

        [JsonPropertyName("effectOfExchangeRate")]
        public ValueContract EffectOfExchangeRate { get; set; }

        [JsonPropertyName("changeInCash")]
        public ValueContract ChangeInCash { get; set; }

        [JsonPropertyName("repurchaseOfStock")]
        public ValueContract RepurchaseOfStock { get; set; }

        [JsonPropertyName("issuanceOfStock")]
        public ValueContract IssuanceOfStock { get; set; }
    }
}