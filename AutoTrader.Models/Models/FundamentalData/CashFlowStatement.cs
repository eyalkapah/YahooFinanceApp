namespace AutoTrader.Models.Models.FundamentalData
{
    public class CashFlowStatement
    {
        public int MaxAge { get; set; }

        public ShortenedValue EndDate { get; set; }

        public Value NetIncome { get; set; }

        public Value Depreciation { get; set; }

        public Value ChangeToNetIncome { get; set; }

        public Value ChangeToAccountReceivables { get; set; }

        public Value ChangeToLiabilities { get; set; }

        public Value ChangeToInventory { get; set; }

        public Value ChangeToOperatingActivities { get; set; }

        public Value TotalCashFromOperatingActivities { get; set; }

        public Value CapitalExpenditures { get; set; }

        public Value Investments { get; set; }

        public Value OtherCashFlowsFromInvestingActivities { get; set; }

        public Value TotalCashFlowsFromInvestingActivities { get; set; }

        public Value DividendsPaid { get; set; }

        public Value NetBorrowings { get; set; }

        public Value OtherCashFlowsFromFinancingActivities { get; set; }

        public Value TotalCashFromFinancingActivities { get; set; }

        public Value EffectOfExchangeRate { get; set; }

        public Value ChangeInCash { get; set; }

        public Value RepurchaseOfStock { get; set; }

        public Value IssuanceOfStock { get; set; }
    }
}
