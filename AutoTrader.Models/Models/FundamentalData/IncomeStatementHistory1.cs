using AutoTrader.Models.Models.FundamentalData.Stubs;

namespace AutoTrader.Models.Models.FundamentalData
{
    public class IncomeStatementHistory1
    {
        public int MaxAge { get; set; }

        public ShortenedValue EndDate { get; set; }

        public Value TotalRevenue { get; set; }

        public Value CostOfRevenue { get; set; }

        public Value GrossProfit { get; set; }

        public Value ResearchDevelopment { get; set; }

        public Value SellingGeneralAdministrative { get; set; }

        public NonrecurringStub NonRecurring { get; set; }

        public OtherOperatingExpensesStub OtherOperatingExpenses { get; set; }

        public Value TotalOperatingExpenses { get; set; }

        public Value OperatingIncome { get; set; }

        public Value TotalOtherIncomeExpenseNet { get; set; }

        public Value Ebit { get; set; }

        public Value InterestExpense { get; set; }

        public Value IncomeBeforeTax { get; set; }

        public Value IncomeTaxExpense { get; set; }

        public MinorityInterestStub MinorityInterest { get; set; }

        public Value NetIncomeFromContinuingOps { get; set; }

        public DiscontinuedOperationsStub DiscontinuedOperations { get; set; }

        public ExtraOrdinaryItemsStub ExtraordinaryItems { get; set; }

        public EffectOfAccountingChargesStub EffectOfAccountingCharges { get; set; }

        public OtherItemsStub OtherItems { get; set; }

        public Value NetIncome { get; set; }

        public Value NetIncomeApplicableToCommonShares { get; set; }
    }
}
