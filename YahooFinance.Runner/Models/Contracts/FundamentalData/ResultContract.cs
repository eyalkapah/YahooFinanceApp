using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class ResultContract
    {
        [JsonPropertyName("assetProfile")]
        public AssetProfileContract AssetProfile { get; set; }

        [JsonPropertyName("recommendationTrend")]
        public RecommendationTrendContract RecommendationTrend { get; set; }

        [JsonPropertyName("cashflowStatementHistory")]
        public CashFlowStatementHistoryContract CashflowStatementHistory { get; set; }

        [JsonPropertyName("indexTrend")]
        public IndexTrendContract IndexTrend { get; set; }

        [JsonPropertyName("defaultKeyStatistics")]
        public DefaultKeyStatisticsContract DefaultKeyStatistics { get; set; }

        [JsonPropertyName("industryTrend")]
        public IndustryTrendContract IndustryTrend { get; set; }

        [JsonPropertyName("incomeStatementHistory")]
        public IncomeStatementHistoryContract IncomeStatementHistory { get; set; }

        [JsonPropertyName("fundOwnership")]
        public FundOwnerShipContract FundOwnership { get; set; }

        [JsonPropertyName("summaryDetail")]
        public SummaryDetailContract SummaryDetail { get; set; }

        [JsonPropertyName("insiderHolders")]
        public InsiderHoldersContract InsiderHolders { get; set; }

        [JsonPropertyName("calendarEvents")]
        public CalendarEventsContract CalendarEvents { get; set; }

        [JsonPropertyName("upgradeDowngradeHistory")]
        public UpgradeDowngradeHistoryContract UpgradeDowngradeHistory { get; set; }

        [JsonPropertyName("price")]
        public PriceContract Price { get; set; }

        [JsonPropertyName("balanceSheetHistory")]
        public BalanceSheetHistoryContract BalanceSheetHistory { get; set; }

        [JsonPropertyName("earningsTrend")]
        public EarningsTrendContract EarningsTrend { get; set; }

        [JsonPropertyName("secFilings")]
        public SecFilingsContract SecFilings { get; set; }

        [JsonPropertyName("institutionOwnership")]
        public InstitutionOwnershipContract InstitutionOwnership { get; set; }

        [JsonPropertyName("majorHoldersBreakdown")]
        public MajorHoldersBreakdownContract MajorHoldersBreakdown { get; set; }

        [JsonPropertyName("balanceSheetHistoryQuarterly")]
        public BalanceSheetHistoryQuarterlyContract BalanceSheetHistoryQuarterly { get; set; }

        [JsonPropertyName("earningsHistory")]
        public EarningshistoryContract EarningsHistory { get; set; }

        [JsonPropertyName("majorDirectHolders")]
        public MajorDirectHoldersContract MajorDirectHolders { get; set; }

        [JsonPropertyName("esgScores")]
        public EsgScoresContract EsgScores { get; set; }

        [JsonPropertyName("summaryProfile")]
        public SummaryProfileContract SummaryProfile { get; set; }

        [JsonPropertyName("netSharePurchaseActivity")]
        public NetSharePurchaseActivityContract NetSharePurchaseActivity { get; set; }

        [JsonPropertyName("insiderTransactions")]
        public InsiderTransactionsContract InsiderTransactions { get; set; }

        [JsonPropertyName("sectorTrend")]
        public SectortrEndContract SectorTrend { get; set; }

        [JsonPropertyName("incomeStatementHistoryQuarterly")]
        public IncomeStatementHistoryQuarterlyContract IncomeStatementHistoryQuarterly { get; set; }

        [JsonPropertyName("cashflowStatementHistoryQuarterly")]
        public CashFlowStatementHistoryQuarterlyContract CashflowStatementHistoryQuarterly { get; set; }

        [JsonPropertyName("earnings")]
        public Earnings1Contract Earnings { get; set; }

        [JsonPropertyName("financialData")]
        public FinancialDataContract FinancialData { get; set; }
    }
}