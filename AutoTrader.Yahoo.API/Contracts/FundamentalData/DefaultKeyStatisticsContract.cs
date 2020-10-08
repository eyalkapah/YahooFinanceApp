using System.Text.Json.Serialization;
using AutoTrader.Yahoo.API.Contracts.FundamentalData.StubClasses;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class DefaultKeyStatisticsContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("priceHint")]
        public ValueContract PriceHint { get; set; }

        [JsonPropertyName("enterpriseValue")]
        public ValueContract EnterpriseValue { get; set; }

        [JsonPropertyName("forwardPE")]
        public ShortenedValueContract ForwardPe { get; set; }

        [JsonPropertyName("profitMargins")]
        public ShortenedValueContract ProfitMargins { get; set; }

        [JsonPropertyName("floatShares")]
        public ValueContract FloatShares { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public ValueContract SharesOutstanding { get; set; }

        [JsonPropertyName("sharesShort")]
        public ValueContract SharesShort { get; set; }

        [JsonPropertyName("sharesShortPriorMonth")]
        public ValueContract SharesShortPriorMonth { get; set; }

        [JsonPropertyName("sharesShortPreviousMonthDate")]
        public ShortenedValueContract SharesShortPreviousMonthDate { get; set; }

        [JsonPropertyName("dateShortInterest")]
        public ShortenedValueContract DateShortInterest { get; set; }

        [JsonPropertyName("sharesPercentSharesOut")]
        public ShortenedValueContract SharesPercentSharesOut { get; set; }

        [JsonPropertyName("heldPercentInsiders")]
        public ShortenedValueContract HeldPercentInsiders { get; set; }

        [JsonPropertyName("heldPercentInstitutions")]
        public ShortenedValueContract HeldPercentInstitutions { get; set; }

        [JsonPropertyName("shortRatio")]
        public ShortenedValueContract ShortRatio { get; set; }

        [JsonPropertyName("shortPercentOfFloat")]
        public ShortenedValueContract ShortPercentOfFloat { get; set; }

        [JsonPropertyName("beta")]
        public ShortenedValueContract Beta { get; set; }

        [JsonPropertyName("morningStarOverallRating")]
        public MorningStarOverallRatingContract MorningStarOverallRating { get; set; }

        [JsonPropertyName("morningStarRiskRating")]
        public MorningStarRiskRatingContract MorningStarRiskRating { get; set; }

        [JsonPropertyName("category")]
        public object Category { get; set; }

        [JsonPropertyName("bookValue")]
        public ShortenedValueContract BookValue { get; set; }

        [JsonPropertyName("priceToBook")]
        public ShortenedValueContract PriceToBook { get; set; }

        [JsonPropertyName("annualReportExpenseRatio")]
        public AnnualReportExpenseRatioContract AnnualReportExpenseRatio { get; set; }

        [JsonPropertyName("ytdReturn")]
        public YtdReturnContract YtdReturn { get; set; }

        [JsonPropertyName("beta3Year")]
        public Beta3YearContract Beta3Year { get; set; }

        [JsonPropertyName("totalAssets")]
        public TotalAssetsContract TotalAssets { get; set; }

        [JsonPropertyName("yield")]
        public YieldContract Yield { get; set; }

        [JsonPropertyName("fundFamily")]
        public object FundFamily { get; set; }

        [JsonPropertyName("fundInceptionDate")]
        public FundInceptionDateContract FundInceptionDate { get; set; }

        [JsonPropertyName("legalType")]
        public object LegalType { get; set; }

        [JsonPropertyName("threeYearAverageReturn")]
        public ThreeYearAverageReturnContract ThreeYearAverageReturn { get; set; }

        [JsonPropertyName("fiveYearAverageReturn")]
        public FiveYearAverageReturnContract FiveYearAverageReturn { get; set; }

        [JsonPropertyName("priceToSalesTrailing12Months")]
        public PriceToSalesTrailing12MonthsContract PriceToSalesTrailing12Months { get; set; }

        [JsonPropertyName("lastFiscalYearEnd")]
        public ShortenedValueContract LastFiscalYearEnd { get; set; }

        [JsonPropertyName("nextFiscalYearEnd")]
        public ShortenedValueContract NextFiscalYearEnd { get; set; }

        [JsonPropertyName("mostRecentQuarter")]
        public ShortenedValueContract MostRecentQuarter { get; set; }

        [JsonPropertyName("earningsQuarterlyGrowth")]
        public ShortenedValueContract EarningsQuarterlyGrowth { get; set; }

        [JsonPropertyName("revenueQuarterlyGrowth")]
        public RevenueQuarterlyGrowthContract RevenueQuarterlyGrowth { get; set; }

        [JsonPropertyName("netIncomeToCommon")]
        public ValueContract NetIncomeToCommon { get; set; }

        [JsonPropertyName("trailingEps")]
        public ShortenedValueContract TrailingEps { get; set; }

        [JsonPropertyName("forwardEps")]
        public ShortenedValueContract ForwardEps { get; set; }

        [JsonPropertyName("pegRatio")]
        public ShortenedValueContract PegRatio { get; set; }

        [JsonPropertyName("lastSplitFactor")]
        public string LastSplitFactor { get; set; }

        [JsonPropertyName("lastSplitDate")]
        public ShortenedValueContract LastSplitDate { get; set; }

        [JsonPropertyName("enterpriseToRevenue")]
        public ShortenedValueContract EnterpriseToRevenue { get; set; }

        [JsonPropertyName("enterpriseToEbitda")]
        public ShortenedValueContract EnterpriseToEbitda { get; set; }

        [JsonPropertyName("52WeekChange")]
        public ShortenedValueContract _52WeekChange { get; set; }

        [JsonPropertyName("SandP52WeekChange")]
        public ShortenedValueContract SandP52WeekChange { get; set; }

        [JsonPropertyName("lastDividendValue")]
        public LastDividendValueContract LastDividendValue { get; set; }

        [JsonPropertyName("lastCapGain")]
        public LastCapGainContract LastCapGain { get; set; }

        [JsonPropertyName("annualHoldingsTurnover")]
        public AnnualHoldingsTurnOverContract AnnualHoldingsTurnover { get; set; }
    }
}