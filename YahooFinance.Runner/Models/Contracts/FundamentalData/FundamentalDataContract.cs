using System;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class FundamentalDataContract
    {
        [JsonPropertyName("quoteSummary")]
        public QuoteSummaryContract QuoteSummary { get; set; }
    }


    public class InsiderHoldersContract
    {
        [JsonPropertyName("holders")]
        public HolderContract[] Holders { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }

    public class HolderContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("relation")]
        public string Relation { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("transactionDescription")]
        public string TransactionDescription { get; set; }

        [JsonPropertyName("latestTransDate")]
        public ShortenedValueContract LatestTransDate { get; set; }

        [JsonPropertyName("positionDirect")]
        public ValueContract PositionDirect { get; set; }

        [JsonPropertyName("positionDirectDate")]
        public ShortenedValueContract PositionDirectDate { get; set; }
    }


    public class CalendarEventsContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("earnings")]
        public EarningsContract Earnings { get; set; }

        [JsonPropertyName("exDividendDate")]
        public ShortenedValueContract ExDividendDate { get; set; }

        [JsonPropertyName("dividendDate")]
        public ShortenedValueContract DividendDate { get; set; }
    }

    public class EarningsContract
    {
        [JsonPropertyName("earningsDate")]
        public ShortenedValueContract[] EarningsDate { get; set; }

        [JsonPropertyName("earningsAverage")]
        public ShortenedValueContract EarningsAverage { get; set; }

        [JsonPropertyName("earningsLow")]
        public ShortenedValueContract EarningsLow { get; set; }

        [JsonPropertyName("earningsHigh")]
        public ShortenedValueContract EarningsHigh { get; set; }

        [JsonPropertyName("revenueAverage")]
        public ValueContract RevenueAverage { get; set; }

        [JsonPropertyName("revenueLow")]
        public ValueContract RevenueLow { get; set; }

        [JsonPropertyName("revenueHigh")]
        public ValueContract RevenueHigh { get; set; }
    }


    public class UpgradeDowngradeHistoryContract
    {
        [JsonPropertyName("history")]
        public HistoryContract[] History { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }

    public class HistoryContract
    {
        [JsonPropertyName("epochGradeDate")]
        public int EpochGradeDate { get; set; }

        [JsonPropertyName("firm")]
        public string Firm { get; set; }

        [JsonPropertyName("toGrade")]
        public string ToGrade { get; set; }

        [JsonPropertyName("fromGrade")]
        public string FromGrade { get; set; }

        [JsonPropertyName("action")]
        public string Action { get; set; }
    }

    public class PriceContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("preMarketChange")]
        public PreMarketChangeContract PreMarketChange { get; set; }

        [JsonPropertyName("preMarketPrice")]
        public PreMarketPriceContract PreMarketPrice { get; set; }

        [JsonPropertyName("preMarketSource")]
        public string PreMarketSource { get; set; }

        [JsonPropertyName("postMarketChangePercent")]
        public ShortenedValueContract PostMarketChangePercent { get; set; }
        
        [JsonPropertyName("postMarketChange")]
        public ShortenedValueContract PostMarketChange { get; set; }

        [JsonPropertyName("postMarketTime")]
        public int PostMarketTime { get; set; }

        [JsonPropertyName("postMarketPrice")]
        public ShortenedValueContract PostMarketPrice { get; set; }

        [JsonPropertyName("postMarketSource")]
        public string PostMarketSource { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public ShortenedValueContract RegularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public ShortenedValueContract RegularMarketChange { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public int RegularMarketTime { get; set; }

        [JsonPropertyName("priceHint")]
        public ValueContract PriceHint { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public ShortenedValueContract RegularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public ShortenedValueContract RegularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public ShortenedValueContract RegularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public ValueContract RegularMarketVolume { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public ValueContract AverageDailyVolume10Day { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public ValueContract AverageDailyVolume3Month { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public ShortenedValueContract RegularMarketPreviousClose { get; set; }

        [JsonPropertyName("regularMarketSource")]
        public string RegularMarketSource { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public ShortenedValueContract RegularMarketOpen { get; set; }

        [JsonPropertyName("strikePrice")]
        public StrikePrice1Contract StrikePrice { get; set; }

        [JsonPropertyName("openInterest")]
        public OpenInterest1Contract OpenInterest { get; set; }

        [JsonPropertyName("exchange")]
        public string Exchange { get; set; }

        [JsonPropertyName("exchangeName")]
        public string ExchangeName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public int ExchangeDataDelayedBy { get; set; }

        [JsonPropertyName("marketState")]
        public string MarketState { get; set; }

        [JsonPropertyName("quoteType")]
        public string QuoteType { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("underlyingSymbol")]
        public object UnderlyingSymbol { get; set; }

        [JsonPropertyName("shortName")]
        public string ShortName { get; set; }

        [JsonPropertyName("longName")]
        public string LongName { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string QuoteSourceName { get; set; }

        [JsonPropertyName("currencySymbol")]
        public string CurrencySymbol { get; set; }

        [JsonPropertyName("fromCurrency")]
        public object FromCurrency { get; set; }

        [JsonPropertyName("toCurrency")]
        public object ToCurrency { get; set; }

        [JsonPropertyName("lastMarket")]
        public object LastMarket { get; set; }

        [JsonPropertyName("volume24Hr")]
        public Volume24Hr1Contract Volume24Hr { get; set; }

        [JsonPropertyName("volumeAllCurrencies")]
        public VolumeAllCurrencies1Contract VolumeAllCurrencies { get; set; }

        [JsonPropertyName("circulatingSupply")]
        public CirculatingSupply1Contract CirculatingSupply { get; set; }

        [JsonPropertyName("marketCap")]
        public ValueContract MarketCap { get; set; }
    }

    public class PreMarketChangeContract
    {
    }

    public class PreMarketPriceContract
    {
    }


    public class StrikePrice1Contract
    {
    }

    public class OpenInterest1Contract
    {
    }

    public class Volume24Hr1Contract
    {
    }

    public class VolumeAllCurrencies1Contract
    {
    }

    public class CirculatingSupply1Contract
    {
    }

  

    public class BalanceSheetHistoryContract
    {
        [JsonPropertyName("balanceSheetStatements")]
        public BalanceSheetStatementContract[] BalanceSheetStatements { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }

    public class BalanceSheetStatementContract
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

        [JsonPropertyName("otherLiab")]
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



    public class EarningsTrendContract
    {
        [JsonPropertyName("trend")]
        public Trend1Contract[] Trend { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }

    public class Trend1Contract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("period")]
        public string Period { get; set; }

        [JsonPropertyName("endDate")]
        public string EndDate { get; set; }

        [JsonPropertyName("growth")]
        public ShortenedValueContract Growth { get; set; }

        [JsonPropertyName("earningsEstimate")]
        public EarningsEstimateContract EarningsEstimate { get; set; }

        [JsonPropertyName("revenueEstimate")]
        public RevenueEstimateContract RevenueEstimate { get; set; }

        [JsonPropertyName("epsTrend")]
        public EpsTrendContract EpsTrend { get; set; }

        [JsonPropertyName("epsRevisions")]
        public EpsRevisionsContract EpsRevisions { get; set; }
    }

    

    public class EarningsEstimateContract
    {
        [JsonPropertyName("avg")]
        public ShortenedValueContract Avg { get; set; }

        [JsonPropertyName("low")]
        public ShortenedValueContract Low { get; set; }

        [JsonPropertyName("high")]
        public ShortenedValueContract High { get; set; }

        [JsonPropertyName("yearAgoEps")]
        public ShortenedValueContract YearAgoEps { get; set; }

        [JsonPropertyName("numberOfAnalysts")]
        public ValueContract NumberOfAnalysts { get; set; }

        [JsonPropertyName("growth")]
        public ShortenedValueContract Growth { get; set; }
    }

  

  

    public class RevenueEstimateContract
    {
        [JsonPropertyName("avg")]
        public ValueContract Avg { get; set; }

        [JsonPropertyName("low")]
        public ValueContract Low { get; set; }

        [JsonPropertyName("high")]
        public ValueContract High { get; set; }

        [JsonPropertyName("numberOfAnalysts")]
        public ValueContract NumberOfAnalysts { get; set; }

        [JsonPropertyName("yearAgoRevenue")]
        public ValueContract YearAgoRevenue { get; set; }

        [JsonPropertyName("growth")]
        public ShortenedValueContract Growth { get; set; }
    }

    

 

    public class EpsTrendContract
    {
        [JsonPropertyName("current")]
        public ShortenedValueContract Current { get; set; }

        [JsonPropertyName("_7daysAgo")]
        public ShortenedValueContract _7daysAgo { get; set; }

        [JsonPropertyName("_30daysAgo")]
        public ShortenedValueContract _30daysAgo { get; set; }

        [JsonPropertyName("_60daysAgo")]
        public ShortenedValueContract _60daysAgo { get; set; }

        [JsonPropertyName("_90daysAgo")]
        public ShortenedValueContract _90daysAgo { get; set; }
    }

  

    public class EpsRevisionsContract
    {
        [JsonPropertyName("upLast7days")]
        public ValueContract UpLast7days { get; set; }

        [JsonPropertyName("upLast30days")]
        public ValueContract UpLast30days { get; set; }

        [JsonPropertyName("downLast30days")]
        public ValueContract DownLast30days { get; set; }

        [JsonPropertyName("downLast90days")]
        public DownLast90daysContract DownLast90days { get; set; }
    }

    

    public class DownLast90daysContract
    {
    }

    public class SecFilingsContract
    {
        [JsonPropertyName("filings")]
        public FilingContract[] Filings { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }

    public class FilingContract
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("epochDate")]
        public int EpochDate { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("edgarUrl")]
        public string EdgarUrl { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }

    public class InstitutionOwnershipContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("ownershipList")]
        public OwnershipList1Contract[] OwnershipList { get; set; }
    }

    public class OwnershipList1Contract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("reportDate")]
        public ShortenedValueContract ReportDate { get; set; }

        [JsonPropertyName("organization")]
        public string Organization { get; set; }

        [JsonPropertyName("pctHeld")]
        public ShortenedValueContract PctHeld { get; set; }

        [JsonPropertyName("position")]
        public ValueContract Position { get; set; }

        [JsonPropertyName("value")]
        public ValueContract Value { get; set; }
    }

   



    public class MajorHoldersBreakdownContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("insidersPercentHeld")]
        public ShortenedValueContract InsidersPercentHeld { get; set; }

        [JsonPropertyName("institutionsPercentHeld")]
        public ShortenedValueContract InstitutionsPercentHeld { get; set; }

        [JsonPropertyName("institutionsFloatPercentHeld")]
        public ShortenedValueContract InstitutionsFloatPercentHeld { get; set; }

        [JsonPropertyName("institutionsCount")]
        public ValueContract InstitutionsCount { get; set; }
    }

 

    public class BalanceSheetHistoryQuarterlyContract
    {
        [JsonPropertyName("balanceSheetStatements")]
        public BalanceSheetStatement1Contract[] BalanceSheetStatements { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }

    public class BalanceSheetStatement1Contract
    {
        [JsonPropertyName("balanceSheetStatements")]
        public int maxAge { get; set; }
        public ShortenedValueContract endDate { get; set; }
        public ValueContract cash { get; set; }
        public ValueContract shortTermInvestments { get; set; }
        public ValueContract netReceivables { get; set; }
        public ValueContract inventory { get; set; }
        public ValueContract otherCurrentAssets { get; set; }
        public ValueContract totalCurrentAssets { get; set; }
        public ValueContract longTermInvestments { get; set; }
        public ValueContract propertyPlantEquipment { get; set; }
        public ValueContract goodWill { get; set; }
        public ValueContract intangibleAssets { get; set; }
        public ValueContract otherAssets { get; set; }
        public ValueContract deferredLongTermAssetCharges { get; set; }
        public ValueContract totalAssets { get; set; }
        public ValueContract accountsPayable { get; set; }
        public ValueContract shortLongTermDebt { get; set; }
        public ValueContract otherCurrentLiab { get; set; }
        public ValueContract longTermDebt { get; set; }
        public ValueContract otherLiab { get; set; }
        public ValueContract totalCurrentLiabilities { get; set; }
        public ValueContract totalLiab { get; set; }
        public ValueContract commonStock { get; set; }
        public ValueContract retainedEarnings { get; set; }
        public ValueContract treasuryStock { get; set; }
        public ValueContract otherStockholderEquity { get; set; }
        public ValueContract totalStockholderEquity { get; set; }
        public ValueContract netTangibleAssets { get; set; }
    }


 

    public class Earningshistory
    {
        public History1[] history { get; set; }
        public int maxAge { get; set; }
    }

    public class History1
    {
        public int maxAge { get; set; }
        public ShortenedValueContract epsActual { get; set; }
        public ShortenedValueContract epsEstimate { get; set; }
        public ShortenedValueContract epsDifference { get; set; }
        public ShortenedValueContract surprisePercent { get; set; }
        public ShortenedValueContract quarter { get; set; }
        public string period { get; set; }
    }


    public class Majordirectholders
    {
        public object[] holders { get; set; }
        public int maxAge { get; set; }
    }

    public class Esgscores
    {
        public int maxAge { get; set; }
        public ShortenedValueContract totalEsg { get; set; }
        public ShortenedValueContract environmentScore { get; set; }
        public ShortenedValueContract socialScore { get; set; }
        public ShortenedValueContract governanceScore { get; set; }
        public int ratingYear { get; set; }
        public int ratingMonth { get; set; }
        public int highestControversy { get; set; }
        public int peerCount { get; set; }
        public string esgPerformance { get; set; }
        public string peerGroup { get; set; }
        public string[] relatedControversy { get; set; }
        public ValueContract peerEsgScorePerformance { get; set; }
        public ValueContract peerGovernancePerformance { get; set; }
        public ValueContract peerSocialPerformance { get; set; }
        public ValueContract peerEnvironmentPerformance { get; set; }
        public ValueContract peerHighestControversyPerformance { get; set; }
        public ShortenedValueContract percentile { get; set; }
        public object environmentPercentile { get; set; }
        public object socialPercentile { get; set; }
        public object governancePercentile { get; set; }
        public bool adult { get; set; }
        public bool alcoholic { get; set; }
        public bool animalTesting { get; set; }
        public bool catholic { get; set; }
        public bool controversialWeapons { get; set; }
        public bool smallArms { get; set; }
        public bool furLeather { get; set; }
        public bool gambling { get; set; }
        public bool gmo { get; set; }
        public bool militaryContract { get; set; }
        public bool nuclear { get; set; }
        public bool pesticides { get; set; }
        public bool palmOil { get; set; }
        public bool coal { get; set; }
        public bool tobacco { get; set; }
    }


    public class Summaryprofile
    {
        public string address1 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public string industry { get; set; }
        public string sector { get; set; }
        public string longBusinessSummary { get; set; }
        public int fullTimeEmployees { get; set; }
        public object[] companyOfficers { get; set; }
        public int maxAge { get; set; }
    }

    public class Netsharepurchaseactivity
    {
        public int maxAge { get; set; }
        public string period { get; set; }
        public ValueContract buyInfoCount { get; set; }
        public ValueContract buyInfoShares { get; set; }
        public ShortenedValueContract buyPercentInsiderShares { get; set; }
        public ValueContract sellInfoCount { get; set; }
        public ValueContract sellInfoShares { get; set; }
        public ShortenedValueContract sellPercentInsiderShares { get; set; }
        public ValueContract netInfoCount { get; set; }
        public ValueContract netInfoShares { get; set; }
        public ShortenedValueContract netPercentInsiderShares { get; set; }
        public ValueContract totalInsiderShares { get; set; }
    }

   

  

    public class Insidertransactions
    {
        public Transaction[] transactions { get; set; }
        public int maxAge { get; set; }
    }

    public class Transaction
    {
        public int maxAge { get; set; }
        public ValueContract shares { get; set; }
        public ValueContract value { get; set; }
        public string filerUrl { get; set; }
        public string transactionText { get; set; }
        public string filerName { get; set; }
        public string filerRelation { get; set; }
        public string moneyText { get; set; }
        public ShortenedValueContract startDate { get; set; }
        public string ownership { get; set; }
    }

   

    public class Sectortrend
    {
        public int maxAge { get; set; }
        public object symbol { get; set; }
        public Peratio2 peRatio { get; set; }
        public Pegratio3 pegRatio { get; set; }
        public object[] estimates { get; set; }
    }

    public class Peratio2
    {
    }

    public class Pegratio3
    {
    }

    public class Incomestatementhistoryquarterly
    {
        public Incomestatementhistory2[] incomeStatementHistory { get; set; }
        public int maxAge { get; set; }
    }

    public class Incomestatementhistory2
    {
        public int maxAge { get; set; }
        public ShortenedValueContract endDate { get; set; }
        public ValueContract totalRevenue { get; set; }
        public ValueContract costOfRevenue { get; set; }
        public ValueContract grossProfit { get; set; }
        public ValueContract researchDevelopment { get; set; }
        public ValueContract sellingGeneralAdministrative { get; set; }
        public NonRecurring1Contract nonRecurring { get; set; }
        public OtherOperatingExpenses1Contract otherOperatingExpenses { get; set; }
        public ValueContract totalOperatingExpenses { get; set; }
        public ValueContract operatingIncome { get; set; }
        public ValueContract totalOtherIncomeExpenseNet { get; set; }
        public ValueContract ebit { get; set; }
        public ValueContract interestExpense { get; set; }
        public ValueContract incomeBeforeTax { get; set; }
        public ValueContract incomeTaxExpense { get; set; }
        public MinorityInterest1Contract minorityInterest { get; set; }
        public ValueContract netIncomeFromContinuingOps { get; set; }
        public DiscontinuedOperations1Contract discontinuedOperations { get; set; }
        public ExtraOrdinaryItems1Contract extraordinaryItems { get; set; }
        public EffectOfAccountingCharges1Contract effectOfAccountingCharges { get; set; }
        public OtherItems1Contract otherItems { get; set; }
        public ValueContract netIncome { get; set; }
        public ValueContract netIncomeApplicableToCommonShares { get; set; }
    }



    public class NonRecurring1Contract
    {
    }

    public class OtherOperatingExpenses1Contract
    {
    }


    public class MinorityInterest1Contract
    {
    }

   

    public class DiscontinuedOperations1Contract
    {
    }

    public class ExtraOrdinaryItems1Contract
    {
    }

    public class EffectOfAccountingCharges1Contract
    {
    }

    public class OtherItems1Contract
    {
    }

 

    public class Cashflowstatementhistoryquarterly
    {
        public Cashflowstatement1[] cashflowStatements { get; set; }
        public int maxAge { get; set; }
    }

    public class Cashflowstatement1
    {
        public int maxAge { get; set; }
        public ShortenedValueContract endDate { get; set; }
        public ValueContract netIncome { get; set; }
        public ValueContract depreciation { get; set; }
        public ValueContract changeToNetincome { get; set; }
        public ValueContract changeToAccountReceivables { get; set; }
        public ValueContract changeToLiabilities { get; set; }
        public ValueContract changeToInventory { get; set; }
        public ValueContract changeToOperatingActivities { get; set; }
        public ValueContract totalCashFromOperatingActivities { get; set; }
        public ValueContract capitalExpenditures { get; set; }
        public ValueContract investments { get; set; }
        public ValueContract otherCashflowsFromInvestingActivities { get; set; }
        public ValueContract totalCashflowsFromInvestingActivities { get; set; }
        public ValueContract dividendsPaid { get; set; }
        public ValueContract otherCashflowsFromFinancingActivities { get; set; }
        public ValueContract totalCashFromFinancingActivities { get; set; }
        public ValueContract effectOfExchangeRate { get; set; }
        public ValueContract changeInCash { get; set; }
        public ValueContract repurchaseOfStock { get; set; }
        public ValueContract issuanceOfStock { get; set; }
        public ValueContract netBorrowings { get; set; }
    }



   
    public class Earnings1
    {
        public int maxAge { get; set; }
        public Earningschart earningsChart { get; set; }
        public Financialschart financialsChart { get; set; }
        public string financialCurrency { get; set; }
    }

    public class Earningschart
    {
        public Quarterly[] quarterly { get; set; }
        public ShortenedValueContract currentQuarterEstimate { get; set; }
        public string currentQuarterEstimateDate { get; set; }
        public int currentQuarterEstimateYear { get; set; }
        public ShortenedValueContract[] earningsDate { get; set; }
    }

   

    public class Quarterly
    {
        public string date { get; set; }
        public ShortenedValueContract actual { get; set; }
        public ShortenedValueContract estimate { get; set; }
    }

   

    public class Financialschart
    {
        public Yearly[] yearly { get; set; }
        public Quarterly1[] quarterly { get; set; }
    }

    public class Yearly
    {
        public int date { get; set; }
        public ValueContract revenue { get; set; }
        public ValueContract earnings { get; set; }
    }

  

    public class Quarterly1
    {
        public string date { get; set; }
        public ValueContract revenue { get; set; }
        public ValueContract earnings { get; set; }
    }

   

    public class Financialdata
    {
        public int maxAge { get; set; }
        public ShortenedValueContract currentPrice { get; set; }
        public ShortenedValueContract targetHighPrice { get; set; }
        public ShortenedValueContract targetLowPrice { get; set; }
        public ShortenedValueContract targetMeanPrice { get; set; }
        public ShortenedValueContract targetMedianPrice { get; set; }
        public ShortenedValueContract recommendationMean { get; set; }
        public string recommendationKey { get; set; }
        public ValueContract numberOfAnalystOpinions { get; set; }
        public ValueContract totalCash { get; set; }
        public ShortenedValueContract totalCashPerShare { get; set; }
        public ValueContract ebitda { get; set; }
        public ValueContract totalDebt { get; set; }
        public ShortenedValueContract quickRatio { get; set; }
        public ShortenedValueContract currentRatio { get; set; }
        public ValueContract totalRevenue { get; set; }
        public ShortenedValueContract debtToEquity { get; set; }
        public ShortenedValueContract revenuePerShare { get; set; }
        public ShortenedValueContract returnOnAssets { get; set; }
        public ShortenedValueContract returnOnEquity { get; set; }
        public ValueContract grossProfits { get; set; }
        public ValueContract freeCashflow { get; set; }
        public ValueContract operatingCashflow { get; set; }
        public ShortenedValueContract earningsGrowth { get; set; }
        public ShortenedValueContract revenueGrowth { get; set; }
        public ShortenedValueContract grossMargins { get; set; }
        public ShortenedValueContract ebitdaMargins { get; set; }
        public ShortenedValueContract operatingMargins { get; set; }
        public ShortenedValueContract profitMargins { get; set; }
        public string financialCurrency { get; set; }
    }

  

 

}
