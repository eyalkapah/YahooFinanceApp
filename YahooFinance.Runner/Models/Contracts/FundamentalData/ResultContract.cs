using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class ResultContract
    {
        [JsonPropertyName("assetProfile")]
        public AssetProfileContract assetProfile { get; set; }

        [JsonPropertyName("recommendationTrend")]
        public RecommendationTrendContract recommendationTrend { get; set; }

        [JsonPropertyName("cashflowStatementHistory")]
        public CashFlowStatementHistoryContract cashflowStatementHistory { get; set; }

        [JsonPropertyName("indexTrend")]
        public ValueContract indexTrend { get; set; }

        [JsonPropertyName("defaultKeyStatistics")]
        public DefaultKeyStatisticsContract defaultKeyStatistics { get; set; }

        [JsonPropertyName("industryTrend")]
        public IndustryTrendContract industryTrend { get; set; }

        [JsonPropertyName("incomeStatementHistory")]
        public IncomeStatementHistoryContract incomeStatementHistory { get; set; }

        [JsonPropertyName("fundOwnership")]
        public FundOwnerShipContract fundOwnership { get; set; }

        [JsonPropertyName("summaryDetail")]
        public SummaryDetailContract summaryDetail { get; set; }

        [JsonPropertyName("insiderHolders")]
        public InsiderHoldersContract insiderHolders { get; set; }

        [JsonPropertyName("calendarEvents")]
        public CalendarEventsContract calendarEvents { get; set; }

        [JsonPropertyName("upgradeDowngradeHistory")]
        public UpgradeDowngradeHistoryContract upgradeDowngradeHistory { get; set; }

        [JsonPropertyName("price")]
        public PriceContract price { get; set; }

        [JsonPropertyName("balanceSheetHistory")]
        public BalanceSheetHistoryContract balanceSheetHistory { get; set; }

        [JsonPropertyName("earningsTrend")]
        public EarningsTrendContract earningsTrend { get; set; }

        [JsonPropertyName("secFilings")]
        public SecFilingsContract secFilings { get; set; }

        [JsonPropertyName("institutionOwnership")]
        public InstitutionOwnershipContract institutionOwnership { get; set; }

        [JsonPropertyName("majorHoldersBreakdown")]
        public MajorHoldersBreakdownContract majorHoldersBreakdown { get; set; }

        [JsonPropertyName("balanceSheetHistoryQuarterly")]
        public BalanceSheetHistoryQuarterlyContract balanceSheetHistoryQuarterly { get; set; }

        [JsonPropertyName("earningsHistory")]
        public Earningshistory earningsHistory { get; set; }

        [JsonPropertyName("majorDirectHolders")]
        public Majordirectholders majorDirectHolders { get; set; }

        [JsonPropertyName("esgScores")]
        public Esgscores esgScores { get; set; }

        [JsonPropertyName("summaryProfile")]
        public Summaryprofile summaryProfile { get; set; }

        [JsonPropertyName("netSharePurchaseActivity")]
        public Netsharepurchaseactivity netSharePurchaseActivity { get; set; }

        [JsonPropertyName("insiderTransactions")]
        public Insidertransactions insiderTransactions { get; set; }

        [JsonPropertyName("sectorTrend")]
        public Sectortrend sectorTrend { get; set; }

        [JsonPropertyName("incomeStatementHistoryQuarterly")]
        public Incomestatementhistoryquarterly incomeStatementHistoryQuarterly { get; set; }

        [JsonPropertyName("cashflowStatementHistoryQuarterly")]
        public Cashflowstatementhistoryquarterly cashflowStatementHistoryQuarterly { get; set; }

        [JsonPropertyName("earnings")]
        public Earnings1 earnings { get; set; }

        [JsonPropertyName("financialData")]
        public Financialdata financialData { get; set; }
    }
}