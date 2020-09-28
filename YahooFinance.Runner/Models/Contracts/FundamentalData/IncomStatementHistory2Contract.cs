using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class IncomStatementHistory2Contract
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
        public NonRecurring1Contract NonRecurring { get; set; }

        [JsonPropertyName("otherOperatingExpenses")]
        public OtherOperatingExpenses1Contract OtherOperatingExpenses { get; set; }

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
        public MinorityInterest1Contract MinorityInterest { get; set; }

        [JsonPropertyName("netIncomeFromContinuingOps")]
        public ValueContract NetIncomeFromContinuingOps { get; set; }

        [JsonPropertyName("discontinuedOperations")]
        public DiscontinuedOperations1Contract DiscontinuedOperations { get; set; }

        [JsonPropertyName("extraordinaryItems")]
        public ExtraOrdinaryItems1Contract ExtraordinaryItems { get; set; }

        [JsonPropertyName("effectOfAccountingCharges")]
        public EffectOfAccountingCharges1Contract EffectOfAccountingCharges { get; set; }

        [JsonPropertyName("otherItems")]
        public OtherItems1Contract OtherItems { get; set; }

        [JsonPropertyName("netIncome")]
        public ValueContract NetIncome { get; set; }

        [JsonPropertyName("netIncomeApplicableToCommonShares")]
        public ValueContract NetIncomeApplicableToCommonShares { get; set; }
    }
}