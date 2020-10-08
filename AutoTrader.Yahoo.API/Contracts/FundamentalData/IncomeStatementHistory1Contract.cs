using System.Text.Json.Serialization;
using AutoTrader.Yahoo.API.Contracts.FundamentalData.StubClasses;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class IncomeStatementHistory1Contract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("endDate")]
        public ShortenedValueContract EndDate { get; set; }

        [JsonPropertyName("totalRevenue")]
        public ValueContract TotalRevenue { get; set; }

        [JsonPropertyName("costOfRevenue")]
        public ValueContract CostOfRevenue { get; set; }

        [JsonPropertyName("grossProfit")]
        public ValueContract GrossProfit { get; set; }

        [JsonPropertyName("researchDevelopment")]
        public ValueContract ResearchDevelopment { get; set; }

        [JsonPropertyName("sellingGeneralAdministrative")]
        public ValueContract SellingGeneralAdministrative { get; set; }

        [JsonPropertyName("nonRecurring")]
        public NonrecurringContract NonRecurring { get; set; }

        [JsonPropertyName("otherOperatingExpenses")]
        public OtherOperatingExpensesContract OtherOperatingExpenses { get; set; }

        [JsonPropertyName("totalOperatingExpenses")]
        public ValueContract TotalOperatingExpenses { get; set; }

        [JsonPropertyName("operatingIncome")]
        public ValueContract OperatingIncome { get; set; }

        [JsonPropertyName("totalOtherIncomeExpenseNet")]
        public ValueContract TotalOtherIncomeExpenseNet { get; set; }

        [JsonPropertyName("ebit")]
        public ValueContract Ebit { get; set; }

        [JsonPropertyName("interestExpense")]
        public ValueContract InterestExpense { get; set; }

        [JsonPropertyName("incomeBeforeTax")]
        public ValueContract IncomeBeforeTax { get; set; }

        [JsonPropertyName("incomeTaxExpense")]
        public ValueContract IncomeTaxExpense { get; set; }

        [JsonPropertyName("minorityInterest")]
        public MinorityInterestContract MinorityInterest { get; set; }

        [JsonPropertyName("netIncomeFromContinuingOps")]
        public ValueContract NetIncomeFromContinuingOps { get; set; }

        [JsonPropertyName("discontinuedOperations")]
        public DiscontinuedOperationsContract DiscontinuedOperations { get; set; }

        [JsonPropertyName("extraordinaryItems")]
        public ExtraOrdinaryItemsContract ExtraordinaryItems { get; set; }

        [JsonPropertyName("effectOfAccountingCharges")]
        public EffectOfAccountingChargesContract EffectOfAccountingCharges { get; set; }

        [JsonPropertyName("otherItems")]
        public OtherItemsContract OtherItems { get; set; }

        [JsonPropertyName("netIncome")]
        public ValueContract NetIncome { get; set; }

        [JsonPropertyName("netIncomeApplicableToCommonShares")]
        public ValueContract NetIncomeApplicableToCommonShares { get; set; }
    }
}