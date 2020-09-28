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
        public EarningshistoryContract earningsHistory { get; set; }

        [JsonPropertyName("majorDirectHolders")]
        public MajorDirectHoldersContract majorDirectHolders { get; set; }

        [JsonPropertyName("esgScores")]
        public EsgScoresContract esgScores { get; set; }

        [JsonPropertyName("summaryProfile")]
        public SummaryProfileContract summaryProfile { get; set; }

        [JsonPropertyName("netSharePurchaseActivity")]
        public NetSharePurchaseActivityContract netSharePurchaseActivity { get; set; }

        [JsonPropertyName("insiderTransactions")]
        public InsiderTransactionsContract insiderTransactions { get; set; }

        [JsonPropertyName("sectorTrend")]
        public SectortrEndContract sectorTrend { get; set; }

        [JsonPropertyName("incomeStatementHistoryQuarterly")]
        public IncomeStatementHistoryQuarterlyContract incomeStatementHistoryQuarterly { get; set; }

        [JsonPropertyName("cashflowStatementHistoryQuarterly")]
        public CashFlowStatementHistoryQuarterlyContract cashflowStatementHistoryQuarterly { get; set; }

        [JsonPropertyName("earnings")]
        public Earnings1Contract earnings { get; set; }

        [JsonPropertyName("financialData")]
        public FinancialDataContract financialData { get; set; }
    }
}