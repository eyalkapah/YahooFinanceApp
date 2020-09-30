namespace YahooFinance.Runner.Models.FundamentalData
{
    public class BalanceSheetStatement
    {
        public int MaxAge { get; set; }

        public ShortenedValue EndDate { get; set; }

        public Value Cash { get; set; }

        public Value ShortTermInvestments { get; set; }

        public Value NetReceivables { get; set; }

        public Value Inventory { get; set; }

        public Value OtherCurrentAssets { get; set; }

        public Value TotalCurrentAssets { get; set; }

        public Value LongTermInvestments { get; set; }

        public Value PropertyPlantEquipment { get; set; }

        public Value GoodWill { get; set; }

        public Value IntangibleAssets { get; set; }

        public Value OtherAssets { get; set; }

        public Value DeferredLongTermAssetCharges { get; set; }

        public Value TotalAssets { get; set; }

        public Value AccountsPayable { get; set; }

        public Value ShortLongTermDebt { get; set; }

        public Value OtherCurrentLiab { get; set; }

        public Value LongTermDebt { get; set; }

        public Value OtherLiab { get; set; }

        public Value TotalCurrentLiabilities { get; set; }

        public Value TotalLiab { get; set; }

        public Value CommonStock { get; set; }

        public Value RetainedEarnings { get; set; }

        public Value TreasuryStock { get; set; }

        public Value OtherStockholderEquity { get; set; }

        public Value TotalStockholderEquity { get; set; }

        public Value NetTangibleAssets { get; set; }
    }
}
