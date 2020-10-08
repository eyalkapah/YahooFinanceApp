using YahooFinance.Runner.Models.FundamentalData.Stubs;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class DefaultKeyStatistics
    {
        public int MaxAge { get; set; }

        public Value PriceHint { get; set; }

        public Value EnterpriseValue { get; set; }

        public ShortenedValue ForwardPe { get; set; }

        public ShortenedValue ProfitMargins { get; set; }

        public Value FloatShares { get; set; }

        public Value SharesOutstanding { get; set; }

        public Value SharesShort { get; set; }

        public Value SharesShortPriorMonth { get; set; }

        public ShortenedValue SharesShortPreviousMonthDate { get; set; }

        public ShortenedValue DateShortInterest { get; set; }

        public ShortenedValue SharesPercentSharesOut { get; set; }

        public ShortenedValue HeldPercentInsiders { get; set; }

        public ShortenedValue HeldPercentInstitutions { get; set; }

        public ShortenedValue ShortRatio { get; set; }

        public ShortenedValue ShortPercentOfFloat { get; set; }

        public ShortenedValue Beta { get; set; }

        public MorningStarOverallRatingStub MorningStarOverallRating { get; set; }

        public MorningStarRiskRatingStub MorningStarRiskRating { get; set; }

        public object Category { get; set; }

        public ShortenedValue BookValue { get; set; }

        public ShortenedValue PriceToBook { get; set; }

        public AnnualReportExpenseRatioStub AnnualReportExpenseRatio { get; set; }

        public YtdReturnStub YtdReturn { get; set; }

        public Beta3YearStub Beta3Year { get; set; }

        public TotalAssetsStub TotalAssets { get; set; }

        public YieldStub Yield { get; set; }

        public object FundFamily { get; set; }

        public FundInceptionDateStub FundInceptionDate { get; set; }

        public object LegalType { get; set; }

        public ThreeYearAverageReturnStub ThreeYearAverageReturn { get; set; }

        public FiveYearAverageReturnStub FiveYearAverageReturn { get; set; }

        public PriceToSalesTrailing12MonthsStub PriceToSalesTrailing12Months { get; set; }

        public ShortenedValue LastFiscalYearEnd { get; set; }

        public ShortenedValue NextFiscalYearEnd { get; set; }

        public ShortenedValue MostRecentQuarter { get; set; }

        public ShortenedValue EarningsQuarterlyGrowth { get; set; }

        public RevenueQuarterlyGrowthStub RevenueQuarterlyGrowth { get; set; }

        public Value NetIncomeToCommon { get; set; }

        public ShortenedValue TrailingEps { get; set; }

        public ShortenedValue ForwardEps { get; set; }

        public ShortenedValue PegRatio { get; set; }

        public string LastSplitFactor { get; set; }

        public ShortenedValue LastSplitDate { get; set; }

        public ShortenedValue EnterpriseToRevenue { get; set; }

        public ShortenedValue EnterpriseToEbitda { get; set; }

        public ShortenedValue _52WeekChange { get; set; }

        public ShortenedValue SandP52WeekChange { get; set; }

        public LastDividendValueStub LastDividendValue { get; set; }

        public LastCapGainStub LastCapGain { get; set; }

        public AnnualHoldingsTurnOverStub AnnualHoldingsTurnover { get; set; }
    }
}
