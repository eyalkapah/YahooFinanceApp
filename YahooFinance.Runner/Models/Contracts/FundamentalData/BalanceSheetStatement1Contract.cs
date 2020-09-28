using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class BalanceSheetStatement1Contract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("endDate")]
        public ShortenedValueContract EndDate { get; set; }

        [JsonPropertyName("cash")]
        public ValueContract Cash { get; set; }

        [JsonPropertyName("shortTermInvestments")]
        public ValueContract ShortTermInvestments { get; set; }

        [JsonPropertyName("netReceivables")]
        public ValueContract NetReceivables { get; set; }

        [JsonPropertyName("inventory")]
        public ValueContract Inventory { get; set; }

        [JsonPropertyName("otherCurrentAssets")]
        public ValueContract OtherCurrentAssets { get; set; }

        [JsonPropertyName("totalCurrentAssets")]
        public ValueContract TotalCurrentAssets { get; set; }

        [JsonPropertyName("longTermInvestments")]
        public ValueContract LongTermInvestments { get; set; }

        [JsonPropertyName("propertyPlantEquipment")]
        public ValueContract PropertyPlantEquipment { get; set; }

        [JsonPropertyName("goodWill")]
        public ValueContract GoodWill { get; set; }

        [JsonPropertyName("intangibleAssets")]
        public ValueContract IntangibleAssets { get; set; }

        [JsonPropertyName("otherAssets")]
        public ValueContract OtherAssets { get; set; }

        [JsonPropertyName("deferredLongTermAssetCharges")]
        public ValueContract DeferredLongTermAssetCharges { get; set; }

        [JsonPropertyName("totalAssets")]
        public ValueContract TotalAssets { get; set; }

        [JsonPropertyName("accountsPayable")]
        public ValueContract AccountsPayable { get; set; }

        [JsonPropertyName("shortLongTermDebt")]
        public ValueContract ShortLongTermDebt { get; set; }

        [JsonPropertyName("otherCurrentLiab")]
        public ValueContract OtherCurrentLiab { get; set; }

        [JsonPropertyName("longTermDebt")]
        public ValueContract LongTermDebt { get; set; }

        [JsonPropertyName("totalCurrentLiabilities")]
        public ValueContract OtherLiab { get; set; }

        [JsonPropertyName("totalCurrentLiabilities")]
        public ValueContract TotalCurrentLiabilities { get; set; }

        [JsonPropertyName("totalLiab")]
        public ValueContract TotalLiab { get; set; }

        [JsonPropertyName("commonStock")]
        public ValueContract CommonStock { get; set; }

        [JsonPropertyName("retainedEarnings")]
        public ValueContract RetainedEarnings { get; set; }

        [JsonPropertyName("treasuryStock")]
        public ValueContract TreasuryStock { get; set; }

        [JsonPropertyName("otherStockholderEquity")]
        public ValueContract OtherStockholderEquity { get; set; }

        [JsonPropertyName("totalStockholderEquity")]
        public ValueContract TotalStockholderEquity { get; set; }

        [JsonPropertyName("netTangibleAssets")]
        public ValueContract NetTangibleAssets { get; set; }
    }
}