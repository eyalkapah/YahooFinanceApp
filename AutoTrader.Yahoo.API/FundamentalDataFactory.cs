using System.Collections.Generic;
using AutoTrader.Models.Models.FundamentalData;
using AutoTrader.Models.Models.FundamentalData.Stubs;
using AutoTrader.Yahoo.API.Contracts.FundamentalData;

namespace AutoTrader.Yahoo.API
{
    public static class FundamentalDataFactory
    {
        public static FundamentalData GetFundamentalData(this FundamentalDataContract contract)
        {
            return new FundamentalData
            {
                QuoteSummary = GetQuoteSummary(contract.QuoteSummary)
            };
        }

        private static QuoteSummary GetQuoteSummary(QuoteSummaryContract quoteSummary)
        {
            return new QuoteSummary
            {
                Error = quoteSummary.Error,
                Result = GetResult(quoteSummary.Result)
            };
        }

        private static IEnumerable<Result> GetResult(IEnumerable<ResultContract> quoteSummaryResult)
        {
            foreach (var resultContract in quoteSummaryResult)
            {
                yield return new Result
                {
                    AssetProfile = GetAsseteProfile(resultContract.AssetProfile),
                    RecommendationTrend = GetRecommendationTrend(resultContract.RecommendationTrend),
                    CashflowStatementHistory = GetCashflowStatementHistory(resultContract.CashflowStatementHistory),
                    IndexTrend = GetIndexTrend(resultContract.IndexTrend),
                    DefaultKeyStatistics = GetDefaultKeyStatistics(resultContract.DefaultKeyStatistics),
                    IndustryTrend = GetIndustryTrend(resultContract.IndustryTrend),
                    IncomeStatementHistory = GetIncomeStatementHistory(resultContract.IncomeStatementHistory),
                    FundOwnership = GetFundOwnership(resultContract.FundOwnership),
                    SummaryDetail = GetSummaryDetail(resultContract.SummaryDetail),
                    InsiderHolders = GetInsiderHolders(resultContract.InsiderHolders),
                    CalendarEvents = GetCalendarEvents(resultContract.CalendarEvents),
                    UpgradeDowngradeHistory = GetUpgradeDowngradeHistory(resultContract.UpgradeDowngradeHistory),
                    Price = GetPrice(resultContract.Price),
                    BalanceSheetHistory = GetBalanceSheetHistory(resultContract.BalanceSheetHistory),
                    EarningsTrend = GetEarningsTrend(resultContract.EarningsTrend),
                    SecFilings = GetSecFilings(resultContract.SecFilings),
                    InstitutionOwnership = GetInstitutionOwnership(resultContract.InstitutionOwnership),
                    MajorHoldersBreakdown = GetMajorHoldersBreakdown(resultContract.MajorHoldersBreakdown),
                    BalanceSheetHistoryQuarterly = GetBalanceSheetHistoryQuarterly(resultContract.BalanceSheetHistoryQuarterly),
                    EarningsHistory = GetEarningsHistory(resultContract.EarningsHistory),
                    MajorDirectHolders = GetMajorDirectHolders(resultContract.MajorDirectHolders),
                    EsgScores = GetEsgScores(resultContract.EsgScores),
                    SummaryProfile = GetSummaryProfile(resultContract.SummaryProfile),
                    NetSharePurchaseActivity = GetNetSharePurchaseActivity(resultContract.NetSharePurchaseActivity),
                    InsiderTransactions = GetInsiderTransactions(resultContract.InsiderTransactions),
                    SectorTrend = GetSectorTrend(resultContract.SectorTrend),
                    IncomeStatementHistoryQuarterly = GetIncomeStatementHistory(resultContract.IncomeStatementHistoryQuarterly),
                    CashFlowStatementHistoryQuarterly = GetCashflowStatementHistory(resultContract.CashflowStatementHistoryQuarterly),
                    Earnings = GetEarnings1(resultContract.Earnings),
                    FinancialData = GetFinancialData(resultContract.FinancialData)

                };
            }
        }

        private static FinancialData GetFinancialData(FinancialDataContract contract)
        {
            if (contract == null)
                return null;

            return new FinancialData
            {
                MaxAge = contract.MaxAge,
                FinancialCurrency = contract.FinancialCurrency,
                Ebitda = GetValue(contract.Ebitda),
                FreeCashflow = GetValue(contract.FreeCashflow),
                GrossProfits = GetValue(contract.GrossProfits),
                NumberOfAnalystOpinions = GetValue(contract.NumberOfAnalystOpinions),
                OperatingCashflow = GetValue(contract.OperatingCashflow),
                RecommendationKey = contract.RecommendationKey,
                CurrentPrice = GetShortenedValue(contract.CurrentPrice),
                CurrentRatio = GetShortenedValue(contract.CurrentRatio),
                DebtToEquity = GetShortenedValue(contract.DebtToEquity),
                EarningsGrowth = GetShortenedValue(contract.EarningsGrowth),
                EbitdaMargins = GetShortenedValue(contract.EbitdaMargins),
                GrossMargins = GetShortenedValue(contract.GrossMargins),
                OperatingMargins = GetShortenedValue(contract.OperatingMargins),
                ProfitMargins = GetShortenedValue(contract.ProfitMargins),
                QuickRatio = GetShortenedValue(contract.QuickRatio),
                RecommendationMean = GetShortenedValue(contract.RecommendationMean),
                ReturnOnAssets = GetShortenedValue(contract.ReturnOnAssets),
                ReturnOnEquity = GetShortenedValue(contract.ReturnOnEquity),
                RevenueGrowth = GetShortenedValue(contract.RevenueGrowth),
                RevenuePerShare = GetShortenedValue(contract.RevenuePerShare),
                TargetHighPrice = GetShortenedValue(contract.TargetHighPrice),
                TargetLowPrice = GetShortenedValue(contract.TargetLowPrice),
                TargetMeanPrice = GetShortenedValue(contract.TargetMeanPrice),
                TargetMedianPrice = GetShortenedValue(contract.TargetMedianPrice),
                TotalCashPerShare = GetShortenedValue(contract.TotalCashPerShare),
                TotalCash = GetValue(contract.TotalCash),
                TotalDebt = GetValue(contract.TotalDebt),
                TotalRevenue = GetValue(contract.TotalRevenue)
            };
        }

        private static Earnings1 GetEarnings1(Earnings1Contract contract)
        {
            if (contract == null)
                return null;

            return new Earnings1
            {
                MaxAge = contract.MaxAge,
                FinancialCurrency = contract.FinancialCurrency,
                EarningsChart = GetEarningsChart(contract.EarningsChart),
                FinancialsChart = GetFinancialsChart(contract.FinancialsChart)
            };
        }

        private static FinancialsChart GetFinancialsChart(FinancialsChartContract contract)
        {
            return new FinancialsChart
            {
                Quarterly = GetQuarterly(contract.Quarterly),
                Yearly = GetYearly(contract.Yearly)
            };
        }

        private static IEnumerable<Yearly> GetYearly(YearlyContract[] contract)
        {
            foreach (var c in contract)
            {
                yield return new Yearly
                {
                    Date = c.Date,
                    Earnings = GetValue(c.Earnings),
                    Revenue = GetValue(c.Revenue)
                };
            }
        }

        private static IEnumerable<Quarterly1> GetQuarterly(Quarterly1Contract[] contract)
        {
            foreach (var c in contract)
            {
                yield return new Quarterly1
                {
                    Date = c.Date,
                    Earnings = GetValue(c.Earnings),
                    Revenue = GetValue(c.Revenue)
                };
            }
        }

        private static EarningsChart GetEarningsChart(EarningsChartContract contract)
        {
            return new EarningsChart
            {
                CurrentQuarterEstimateYear = contract.CurrentQuarterEstimateYear,
                CurrentQuarterEstimateDate = contract.CurrentQuarterEstimateDate,
                CurrentQuarterEstimate = GetShortenedValue(contract.CurrentQuarterEstimate),
                EarningsDate = GetShortenedValues(contract.EarningsDate)
            };
        }

        private static IEnumerable<ShortenedValue> GetShortenedValues(ShortenedValueContract[] contract)
        {
            foreach (var c in contract)
            {
                yield return GetShortenedValue(c);
            }
        }

        private static SectorEnd GetSectorTrend(SectorEndContract contract)
        {
            if (contract == null)
                return null;

            return new SectorEnd
            {
                MaxAge = contract.MaxAge,
                Symbol = contract.Symbol,
                Estimates = contract.Estimates,
                PeRatio = GetStub<PeRatio2Stub>(),
                PegRatio = GetStub<PegRatio3Stub>()
            };
        }

        private static InsiderTransactions GetInsiderTransactions(InsiderTransactionsContract contract)
        {
            if (contract == null)
                return null;

            return new InsiderTransactions
            {
                MaxAge = contract.MaxAge,
                Transactions = GetTransactions(contract.Transactions)
            };
        }

        private static IEnumerable<Transaction> GetTransactions(TransactionContract[] contract)
        {
            foreach (var c in contract)
            {
                yield return new Transaction
                {
                    MaxAge = c.MaxAge,
                    FilerName = c.FilerName,
                    FilerRelation = c.FilerRelation,
                    FilerUrl = c.FilerUrl,
                    MoneyText = c.MoneyText,
                    Ownership = c.Ownership,
                    TransactionText = c.TransactionText,
                    Value = GetValue(c.Value),
                    Shares = GetValue(c.Shares),
                    StartDate = GetShortenedValue(c.StartDate)
                };
            }
        }

        private static NetSharePurchaseActivity GetNetSharePurchaseActivity(NetSharePurchaseActivityContract contract)
        {
            if (contract == null)
                return null;

            return new NetSharePurchaseActivity
            {
                MaxAge = contract.MaxAge,
                Period = contract.Period,
                BuyInfoCount = GetValue(contract.BuyInfoCount),
                BuyInfoShares = GetValue(contract.BuyInfoShares),
                BuyPercentInsiderShares = GetShortenedValue(contract.BuyPercentInsiderShares),
                NetInfoCount = GetValue(contract.NetInfoCount),
                NetInfoShares = GetValue(contract.NetInfoShares),
                NetPercentInsiderShares = GetShortenedValue(contract.NetPercentInsiderShares),
                SellInfoCount = GetValue(contract.SellInfoCount),
                SellInfoShares = GetValue(contract.SellInfoShares),
                SellPercentInsiderShares = GetShortenedValue(contract.SellPercentInsiderShares),
                TotalInsiderShares = GetValue(contract.TotalInsiderShares)
            };
        }

        private static SummaryProfile GetSummaryProfile(SummaryProfileContract contract)
        {
            if (contract == null)
                return null;

            return new SummaryProfile
            {
                MaxAge = contract.MaxAge,
                Address1 = contract.Address1,
                City = contract.City,
                CompanyOfficers = contract.CompanyOfficers,
                Country = contract.Country,
                FullTimeEmployees = contract.FullTimeEmployees,
                Industry = contract.Industry,
                LongBusinessSummary = contract.LongBusinessSummary,
                Phone = contract.Phone,
                Sector = contract.Sector,
                State = contract.State,
                Website = contract.Website,
                Zip = contract.Zip
            };
        }

        private static EsgScores GetEsgScores(EsgScoresContract contract)
        {
            if (contract == null)
                return null;

            return new EsgScores
            {
                MaxAge = contract.MaxAge,
                Adult = contract.Adult,
                Alcoholic = contract.Alcoholic,
                AnimalTesting = contract.AnimalTesting,
                Catholic = contract.Catholic,
                Coal = contract.Coal,
                ControversialWeapons = contract.ControversialWeapons,
                EnvironmentPercentile = contract.EnvironmentPercentile,
                EnvironmentScore = GetShortenedValue(contract.EnvironmentScore),
                EsgPerformance = contract.EsgPerformance,
                FurLeather = contract.FurLeather,
                Gambling = contract.Gambling,
                Gmo = contract.Gmo,
                GovernancePercentile = contract.GovernancePercentile,
                GovernanceScore = GetShortenedValue(contract.GovernanceScore),
                HighestControversy = contract.HighestControversy,
                MilitaryContract = contract.MilitaryContract,
                Nuclear = contract.Nuclear,
                PalmOil = contract.PalmOil,
                PeerCount = contract.PeerCount,
                PeerEnvironmentPerformance = GetValue(contract.PeerEnvironmentPerformance),
                PeerEsgScorePerformance = GetValue(contract.PeerEsgScorePerformance),
                PeerGovernancePerformance = GetValue(contract.PeerGovernancePerformance),
                PeerGroup = contract.PeerGroup,
                PeerHighestControversyPerformance = GetValue(contract.PeerHighestControversyPerformance),
                PeerSocialPerformance = GetValue(contract.PeerSocialPerformance),
                Percentile = GetShortenedValue(contract.Percentile),
                Pesticides = contract.Pesticides,
                RatingMonth = contract.RatingMonth,
                RatingYear = contract.RatingYear,
                RelatedControversy = contract.RelatedControversy,
                SmallArms = contract.SmallArms,
                SocialPercentile = contract.SocialPercentile,
                SocialScore = GetShortenedValue(contract.SocialScore),
                Tobacco = contract.Tobacco,
                TotalEsg = GetShortenedValue(contract.TotalEsg)
            };
        }

        private static MajorDirectHolders GetMajorDirectHolders(MajorDirectHoldersContract contract)
        {
            return new MajorDirectHolders
            {
                MaxAge = contract.MaxAge,
                Holders = contract.Holders
            };
        }

        private static EarningsHistory GetEarningsHistory(EarningsHistoryContract contract)
        {
            if (contract == null)
                return null;

            return new EarningsHistory
            {
                MaxAge = contract.MaxAge,
                History = GetHistory(contract.History)
            };
        }

        private static IEnumerable<History1> GetHistory(History1Contract[] contract)
        {
            foreach (var c in contract)
            {
                yield return new History1
                {
                    MaxAge = c.MaxAge,
                    Period = c.Period,
                    EpsActual = GetShortenedValue(c.EpsActual),
                    EpsDifference = GetShortenedValue(c.EpsDifference),
                    EpsEstimate = GetShortenedValue(c.EpsEstimate),
                    Quarter = GetShortenedValue(c.Quarter),
                    SurprisePercent = GetShortenedValue(c.SurprisePercent)
                };
            }
        }

        private static BalanceSheetHistoryQuarterly GetBalanceSheetHistoryQuarterly(BalanceSheetHistoryQuarterlyContract contract)
        {
            if (contract == null)
                return null;

            return new BalanceSheetHistoryQuarterly
            {
                MaxAge = contract.MaxAge,
                BalanceSheetStatements = GetBalanceSheetStatements(contract.BalanceSheetStatements)
            };
        }


        private static MajorHoldersBreakdown GetMajorHoldersBreakdown(MajorHoldersBreakdownContract contract)
        {
            if (contract == null)
                return null;

            return new MajorHoldersBreakdown
            {
                InsidersPercentHeld = GetShortenedValue(contract.InsidersPercentHeld),
                InstitutionsFloatPercentHeld = GetShortenedValue(contract.InstitutionsFloatPercentHeld),
                InstitutionsPercentHeld = GetShortenedValue(contract.InstitutionsPercentHeld),
                InstitutionsCount = GetValue(contract.InstitutionsCount),
                MaxAge = contract.MaxAge
            };
        }

        private static InstitutionOwnership GetInstitutionOwnership(InstitutionOwnershipContract contract)
        {
            if (contract == null)
                return null;

            return new InstitutionOwnership
            {
                MaxAge = contract.MaxAge,
                OwnershipList = GetOwnershipList(contract.OwnershipList)
            };
        }

        private static IEnumerable<OwnershipList1> GetOwnershipList(OwnershipList1Contract[] contract)
        {
            foreach (var c in contract)
            {
                yield return new OwnershipList1
                {
                    MaxAge = c.MaxAge,
                    Organization = c.Organization,
                    PctHeld = GetShortenedValue(c.PctHeld),
                    Position = GetValue(c.Position),
                    ReportDate = GetShortenedValue(c.ReportDate),
                    Value = GetValue(c.Value)
                };
            }
        }

        private static SecFilings GetSecFilings(SecFilingsContract contract)
        {
            if (contract == null)
                return null;

            return new SecFilings
            {
                MaxAge = contract.MaxAge,
                Filings = GetFilings(contract.Filings)
            };
        }

        private static IEnumerable<Filing> GetFilings(FilingContract[] contract)
        {
            foreach (var c in contract)
            {
                yield return new Filing
                {
                    MaxAge = c.MaxAge,
                    EpochDate = c.EpochDate,
                    Date = c.Date,
                    EdgarUrl = c.EdgarUrl,
                    Title = c.Title,
                    Type = c.Type
                };
            }
        }

        private static EarningsTrend GetEarningsTrend(EarningsTrendContract contract)
        {
            if (contract == null)
                return null;

            return new EarningsTrend
            {
                MaxAge = contract.MaxAge,
                Trend = GetTrends(contract.Trend)
            };
        }

        private static IEnumerable<Trend1> GetTrends(Trend1Contract[] contract)
        {
            foreach (var c in contract)
            {
                yield return new Trend1
                {
                    EndDate = c.EndDate,
                    MaxAge = c.MaxAge,
                    Period = c.Period,
                    EarningsEstimate = GetEarningsEstimate(c.EarningsEstimate),
                    Growth = GetShortenedValue(c.Growth),
                    EpsRevisions = GetEpsRevisions(c.EpsRevisions),
                    EpsTrend = GetEpsTrend(c.EpsTrend),
                    RevenueEstimate = GetRevenueEstimate(c.RevenueEstimate)
                };
            }
        }

        private static RevenueEstimate GetRevenueEstimate(RevenueEstimateContract contract)
        {
            return new RevenueEstimate
            {
                High = GetValue(contract.High),
                Low = GetValue(contract.Low),
                Avg = GetValue(contract.Avg),
                NumberOfAnalysts = GetValue(contract.NumberOfAnalysts),
                YearAgoRevenue = GetValue(contract.YearAgoRevenue),
                Growth = GetShortenedValue(contract.Growth)
            };
        }

        private static EpsTrend GetEpsTrend(EpsTrendContract contract)
        {
            return new EpsTrend
            {
                Current = GetShortenedValue(contract.Current),
                _30daysAgo = GetShortenedValue(contract._30daysAgo),
                _60daysAgo = GetShortenedValue(contract._60daysAgo),
                _7daysAgo = GetShortenedValue(contract._7daysAgo),
                _90daysAgo = GetShortenedValue(contract._90daysAgo)
            };
        }

        private static EpsRevisions GetEpsRevisions(EpsRevisionsContract contract)
        {
            return new EpsRevisions
            {
                DownLast30days = GetValue(contract.DownLast30days),
                UpLast30days = GetValue(contract.UpLast30days),
                UpLast7days = GetValue(contract.UpLast7days),
                DownLast90days = GetStub<DownLast90days>()
            };
        }

        private static EarningsEstimate GetEarningsEstimate(EarningsEstimateContract contract)
        {
            return new EarningsEstimate
            {
                Low = GetShortenedValue(contract.Low),
                High = GetShortenedValue(contract.High),
                Avg = GetShortenedValue(contract.Avg),
                Growth = GetShortenedValue(contract.Growth),
                NumberOfAnalysts = GetValue(contract.NumberOfAnalysts),
                YearAgoEps = GetShortenedValue(contract.YearAgoEps)
            };
        }

        private static BalanceSheetHistory GetBalanceSheetHistory(BalanceSheetHistoryContract contract)
        {
            return new BalanceSheetHistory
            {
                MaxAge = contract.MaxAge,
                BalanceSheetStatements = GetBalanceSheetStatements(contract.BalanceSheetStatements)
            };
        }

        private static IEnumerable<BalanceSheetStatement> GetBalanceSheetStatements(BalanceSheetStatementContract[] contract)
        {
            foreach (var c in contract)
            {
                yield return new BalanceSheetStatement
                {
                    AccountsPayable = GetValue(c.AccountsPayable),
                    Cash = GetValue(c.Cash),
                    CommonStock = GetValue(c.CommonStock),
                    DeferredLongTermAssetCharges = GetValue(c.DeferredLongTermAssetCharges),
                    EndDate = GetShortenedValue(c.EndDate),
                    GoodWill = GetValue(c.GoodWill),
                    IntangibleAssets = GetValue(c.IntangibleAssets),
                    Inventory = GetValue(c.Inventory),
                    LongTermDebt = GetValue(c.LongTermDebt),
                    LongTermInvestments = GetValue(c.LongTermInvestments),
                    MaxAge = c.MaxAge,
                    NetReceivables = GetValue(c.NetReceivables),
                    NetTangibleAssets = GetValue(c.NetTangibleAssets),
                    OtherAssets = GetValue(c.OtherAssets),
                    OtherCurrentAssets = GetValue(c.OtherCurrentAssets),
                    OtherCurrentLiab = GetValue(c.OtherCurrentLiab),
                    OtherLiab = GetValue(c.OtherLiab),
                    OtherStockholderEquity = GetValue(c.OtherStockholderEquity),
                    PropertyPlantEquipment = GetValue(c.PropertyPlantEquipment),
                    RetainedEarnings = GetValue(c.RetainedEarnings),
                    ShortLongTermDebt = GetValue(c.ShortLongTermDebt),
                    ShortTermInvestments = GetValue(c.ShortTermInvestments),
                    TotalAssets = GetValue(c.TotalAssets),
                    TotalCurrentAssets = GetValue(c.TotalCurrentAssets),
                    TotalCurrentLiabilities = GetValue(c.TotalCurrentLiabilities),
                    TotalLiab = GetValue(c.TotalLiab),
                    TotalStockholderEquity = GetValue(c.TotalStockholderEquity),
                    TreasuryStock = GetValue(c.TreasuryStock)
                };
            }
        }

        private static Price GetPrice(PriceContract contract)
        {
            if (contract == null)
                return null;

            return new Price
            {
                PriceHint = GetValue(contract.PriceHint),
                RegularMarketPrice = GetShortenedValue(contract.RegularMarketPrice),
                ExchangeName = contract.ExchangeName,
                Symbol = contract.Symbol,
                Currency = contract.Currency,
                RegularMarketTime = contract.RegularMarketTime,
                AverageDailyVolume10Day = GetValue(contract.AverageDailyVolume10Day),
                AverageDailyVolume3Month = GetValue(contract.AverageDailyVolume3Month),
                CirculatingSupply = GetStub<CirculatingSupply1Stub>(),
                CurrencySymbol = contract.CurrencySymbol,
                Exchange = contract.Exchange,
                ExchangeDataDelayedBy = contract.ExchangeDataDelayedBy,
                FromCurrency = contract.FromCurrency,
                LastMarket = contract.LastMarket,
                LongName = contract.LongName,
                MarketCap = GetValue(contract.MarketCap),
                MarketState = contract.MarketState,
                MaxAge = contract.MaxAge,
                OpenInterest = GetStub<OpenInterest1Stub>(),
                PostMarketChange = GetShortenedValue(contract.PostMarketChange),
                PostMarketChangePercent = GetShortenedValue(contract.PostMarketChangePercent),
                PostMarketPrice = GetShortenedValue(contract.PostMarketPrice),
                PostMarketSource = contract.PostMarketSource,
                PostMarketTime = contract.PostMarketTime,
                PreMarketChange = GetStub<PreMarketChangeStub>(),
                PreMarketPrice = GetStub<PreMarketPriceStub>(),
                PreMarketSource = contract.PreMarketSource,
                QuoteSourceName = contract.QuoteSourceName,
                QuoteType = contract.QuoteType,
                RegularMarketChange = GetShortenedValue(contract.RegularMarketChange),
                RegularMarketChangePercent = GetShortenedValue(contract.RegularMarketChangePercent),
                RegularMarketDayHigh = GetShortenedValue(contract.RegularMarketDayHigh),
                RegularMarketDayLow = GetShortenedValue(contract.RegularMarketDayLow),
                RegularMarketOpen = GetShortenedValue(contract.RegularMarketOpen),
                RegularMarketPreviousClose = GetShortenedValue(contract.RegularMarketPreviousClose),
                RegularMarketSource = contract.RegularMarketSource,
                RegularMarketVolume = GetValue(contract.RegularMarketVolume),
                ShortName = contract.ShortName,
                StrikePrice = GetStub<StrikePrice1Stub>(),
                ToCurrency = contract.ToCurrency,
                UnderlyingSymbol = contract.UnderlyingSymbol,
                Volume24Hr = GetStub<Volume24Hr1Stub>(),
                VolumeAllCurrencies = GetStub<VolumeAllCurrencies1Stub>()

            };
        }

        private static UpgradeDowngradeHistory GetUpgradeDowngradeHistory(UpgradeDowngradeHistoryContract contract)
        {
            if (contract == null)
                return null;

            return new UpgradeDowngradeHistory
            {
                MaxAge = contract.MaxAge,
                History = GetHistory(contract.History)
            };
        }

        private static IEnumerable<History> GetHistory(HistoryContract[] contract)
        {
            foreach (var c in contract)
            {
                yield return new History
                {
                    Action = c.Action,
                    EpochGradeDate = c.EpochGradeDate,
                    Firm = c.Firm,
                    FromGrade = c.FromGrade,
                    ToGrade = c.ToGrade
                };
            }
        }

        private static CalendarEvents GetCalendarEvents(CalendarEventsContract contract)
        {
            if (contract == null)
                return null;

            return new CalendarEvents
            {
                DividendDate = GetShortenedValue(contract.DividendDate),
                ExDividendDate = GetShortenedValue(contract.ExDividendDate),
                MaxAge = contract.MaxAge,
                Earnings = GetEarnings(contract.Earnings)
            };
        }

        private static Earnings GetEarnings(EarningsContract contract)
        {
            return new Earnings
            {
                EarningsAverage = GetShortenedValue(contract.EarningsAverage),
                EarningsDate = GetEarningsDate(contract.EarningsDate),
                EarningsHigh = GetShortenedValue(contract.EarningsHigh),
                EarningsLow = GetShortenedValue(contract.EarningsLow),
                RevenueAverage = GetValue(contract.RevenueAverage),
                RevenueHigh = GetValue(contract.RevenueHigh),
                RevenueLow = GetValue(contract.RevenueLow)
            };
        }

        private static IEnumerable<ShortenedValue> GetEarningsDate(ShortenedValueContract[] contract)
        {
            foreach (var c in contract)
            {
                yield return GetShortenedValue(c);
            }

        }

        private static InsiderHolders GetInsiderHolders(InsiderHoldersContract contract)
        {
            return new InsiderHolders
            {
                MaxAge = contract.MaxAge,
                Holders = GetInsiderHolders(contract.Holders)
            };
        }

        private static IEnumerable<Holder> GetInsiderHolders(HolderContract[] holders)
        {
            foreach (var c in holders)
            {
                yield return new Holder
                {
                    MaxAge = c.MaxAge,
                    LatestTransDate = GetShortenedValue(c.LatestTransDate),
                    Name = c.Name,
                    PositionDirect = GetValue(c.PositionDirect),
                    PositionDirectDate = GetShortenedValue(c.PositionDirectDate),
                    Relation = c.Relation,
                    TransactionDescription = c.TransactionDescription,
                    Url = c.Url
                };
            }
        }

        private static SummaryDetail GetSummaryDetail(SummaryDetailContract contract)
        {
            return new SummaryDetail
            {
                Algorithm = contract.Algorithm,
                Ask = GetShortenedValue(contract.Ask),
                AskSize = GetValue(contract.AskSize),
                AverageDailyVolume10Day = GetValue(contract.AverageDailyVolume10Day),
                AverageVolume = GetValue(contract.AverageVolume),
                AverageVolume10days = GetValue(contract.AverageVolume10days),
                Beta = GetShortenedValue(contract.Beta),
                Bid = GetShortenedValue(contract.Bid),
                BidSize = GetValue(contract.BidSize),
                CirculatingSupply = GetStub<CirculatingSupplyStub>(),
                Currency = contract.Currency,
                DayHigh = GetShortenedValue(contract.DayHigh),
                DayLow = GetShortenedValue(contract.DayLow),
                DividendRate = GetShortenedValue(contract.DividendRate),
                DividendYield = GetShortenedValue(contract.DividendYield),
                ExDividendDate = GetShortenedValue(contract.ExDividendDate),
                ExpireDate = GetStub<ExpireDateStub>(),
                FiftyDayAverage = GetShortenedValue(contract.FiftyDayAverage),
                FiftyTwoWeekHigh = GetShortenedValue(contract.FiftyTwoWeekHigh),
                FiftyTwoWeekLow = GetShortenedValue(contract.FiftyTwoWeekLow),
                FiveYearAvgDividendYield = GetShortenedValue(contract.FiveYearAvgDividendYield),
                ForwardPe = GetShortenedValue(contract.ForwardPe),
                FromCurrency = contract.FromCurrency,
                LastMarket = contract.LastMarket,
                MarketCap = GetValue(contract.MarketCap),
                MaxAge = contract.MaxAge,
                MaxSupply = GetStub<MaxSupplyStub>(),
                NavPrice = GetStub<NavPriceStub>(),
                Open = GetShortenedValue(contract.Open),
                OpenInterest = GetStub<OpenInterestStub>(),
                PayoutRatio = GetShortenedValue(contract.PayoutRatio),
                PreviousClose = GetShortenedValue(contract.PreviousClose),
                PriceHint = GetValue(contract.PriceHint),
                Yield = GetStub<Yield1Stub>(),
                YtdReturn = GetStub<YtdReturn1Stub>(),
                TotalAssets = GetStub<TotalAssets1Stub>(),
                PriceToSalesTrailing12Months = GetShortenedValue(contract.PriceToSalesTrailing12Months),
                RegularMarketDayHigh = GetShortenedValue(contract.RegularMarketDayHigh),
                RegularMarketDayLow = GetShortenedValue(contract.RegularMarketDayLow),
                RegularMarketOpen = GetShortenedValue(contract.RegularMarketOpen),
                RegularMarketPreviousClose = GetShortenedValue(contract.RegularMarketPreviousClose),
                RegularMarketVolume = GetValue(contract.RegularMarketVolume),
                StartDate = GetStub<StartDateStub>(),
                StrikePrice = GetStub<StrikePriceStub>(),
                ToCurrency = contract.ToCurrency,
                Tradeable = contract.Tradeable,
                TrailingAnnualDividendRate = GetShortenedValue(contract.TrailingAnnualDividendRate),
                TrailingAnnualDividendYield = GetShortenedValue(contract.TrailingAnnualDividendYield),
                TrailingPe = GetShortenedValue(contract.TrailingPe),
                TwoHundredDayAverage = GetShortenedValue(contract.TwoHundredDayAverage),
                Volume = GetValue(contract.Volume),
                Volume24Hr = GetStub<Volume24HrStub>(),
                VolumeAllCurrencies = GetStub<VolumeAllCurrenciesStub>()
            };
        }

        private static FundOwnerShip GetFundOwnership(FundOwnerShipContract contract)
        {
            return new FundOwnerShip
            {
                MaxAge = contract.MaxAge,
                OwnershipList = GetOwnershipList(contract.OwnershipList)
            };
        }

        private static IEnumerable<OwnerShipList> GetOwnershipList(OwnerShipListContract[] contract)
        {
            foreach (var c in contract)
            {
                yield return new OwnerShipList
                {
                    MaxAge = c.MaxAge,
                    Organization = c.Organization,
                    PctHeld = GetShortenedValue(c.PctHeld),
                    Position = GetValue(c.Position),
                    ReportDate = GetShortenedValue(c.ReportDate),
                    Value = GetValue(c.Value)
                };
            }
        }

        private static IncomeStatementHistory GetIncomeStatementHistory(IncomeStatementHistoryContract contract)
        {
            return new IncomeStatementHistory
            {
                MaxAge = contract.MaxAge,
                IncomeStatementsHistory = GetIncomeStatementsHistory(contract.IncomeStatementHistory)
            };
        }

        private static IEnumerable<IncomeStatementHistory1> GetIncomeStatementsHistory(IncomeStatementHistory1Contract[] contract)
        {
            foreach (var c in contract)
            {
                yield return new IncomeStatementHistory1
                {
                    MaxAge = c.MaxAge,
                    CostOfRevenue = GetValue(c.CostOfRevenue),
                    DiscontinuedOperations = GetStub<DiscontinuedOperationsStub>(),
                    Ebit = GetValue(c.Ebit),
                    EffectOfAccountingCharges = GetStub<EffectOfAccountingChargesStub>(),
                    EndDate = GetShortenedValue(c.EndDate),
                    NetIncome = GetValue(c.NetIncome),
                    ExtraordinaryItems = GetStub<ExtraOrdinaryItemsStub>(),
                    GrossProfit = GetValue(c.GrossProfit),
                    IncomeBeforeTax = GetValue(c.IncomeBeforeTax),
                    IncomeTaxExpense = GetValue(c.IncomeTaxExpense),
                    InterestExpense = GetValue(c.InterestExpense),
                    MinorityInterest = GetStub<MinorityInterestStub>(),
                    NetIncomeApplicableToCommonShares = GetValue(c.NetIncomeApplicableToCommonShares),
                    NetIncomeFromContinuingOps = GetValue(c.NetIncomeFromContinuingOps),
                    NonRecurring = GetStub<NonrecurringStub>(),
                    OperatingIncome = GetValue(c.OperatingIncome),
                    OtherItems = GetStub<OtherItemsStub>(),
                    OtherOperatingExpenses = GetStub<OtherOperatingExpensesStub>(),
                    ResearchDevelopment = GetValue(c.ResearchDevelopment),
                    SellingGeneralAdministrative = GetValue(c.SellingGeneralAdministrative),
                    TotalOperatingExpenses = GetValue(c.TotalOperatingExpenses),
                    TotalOtherIncomeExpenseNet = GetValue(c.TotalOtherIncomeExpenseNet),
                    TotalRevenue = GetValue(c.TotalRevenue)
                };
            }
        }

        private static IndustryTrend GetIndustryTrend(IndustryTrendContract contract)
        {
            if (contract == null)
                return null;

            return new IndustryTrend
            {
                MaxAge = contract.MaxAge,
                PegRatio = GetStub<PegRatio2Stub>(),
                PeRatio = GetStub<PeRatio1Stub>(),
                Symbol = contract.Symbol,
                Estimates = contract.Estimates
            };
        }

        private static DefaultKeyStatistics GetDefaultKeyStatistics(DefaultKeyStatisticsContract contract)
        {
            if (contract == null)
                return null;

            return new DefaultKeyStatistics
            {
                AnnualHoldingsTurnover = GetStub<AnnualHoldingsTurnOverStub>(),
                AnnualReportExpenseRatio = GetStub<AnnualReportExpenseRatioStub>(),
                Beta = GetShortenedValue(contract.Beta),
                Beta3Year = GetStub<Beta3YearStub>(),
                BookValue = GetShortenedValue(contract.BookValue),
                Category = contract.Category,
                DateShortInterest = GetShortenedValue(contract.DateShortInterest),
                EarningsQuarterlyGrowth = GetShortenedValue(contract.EarningsQuarterlyGrowth),
                EnterpriseToEbitda = GetShortenedValue(contract.EnterpriseToEbitda),
                EnterpriseToRevenue = GetShortenedValue(contract.EnterpriseToRevenue),
                EnterpriseValue = GetValue(contract.EnterpriseValue),
                FiveYearAverageReturn = GetStub<FiveYearAverageReturnStub>(),
                FloatShares = GetValue(contract.FloatShares),
                ForwardEps = GetShortenedValue(contract.ForwardEps),
                ForwardPe = GetShortenedValue(contract.ForwardPe),
                FundFamily = contract.FundFamily,
                FundInceptionDate = GetStub<FundInceptionDateStub>(),
                HeldPercentInsiders = GetShortenedValue(contract.HeldPercentInsiders),
                HeldPercentInstitutions = GetShortenedValue(contract.HeldPercentInstitutions),
                LastCapGain = GetStub<LastCapGainStub>(),
                LastDividendValue = GetStub<LastDividendValueStub>(),
                LastFiscalYearEnd = GetShortenedValue(contract.LastFiscalYearEnd),
                LastSplitDate = GetShortenedValue(contract.LastSplitDate),
                LastSplitFactor = contract.LastSplitFactor,
                LegalType = contract.LegalType,
                MaxAge = contract.MaxAge,
                PegRatio = GetShortenedValue(contract.PegRatio),
                MorningStarOverallRating = GetStub<MorningStarOverallRatingStub>(),
                MorningStarRiskRating = GetStub<MorningStarRiskRatingStub>(),
                MostRecentQuarter = GetShortenedValue(contract.MostRecentQuarter),
                NetIncomeToCommon = GetValue(contract.NetIncomeToCommon),
                NextFiscalYearEnd = GetShortenedValue(contract.NextFiscalYearEnd),
                PriceHint = GetValue(contract.PriceHint),
                PriceToBook = GetShortenedValue(contract.PriceToBook),
                PriceToSalesTrailing12Months = GetStub<PriceToSalesTrailing12MonthsStub>(),
                ProfitMargins = GetShortenedValue(contract.ProfitMargins),
                RevenueQuarterlyGrowth = GetStub<RevenueQuarterlyGrowthStub>(),
                SandP52WeekChange = GetShortenedValue(contract.SandP52WeekChange),
                SharesOutstanding = GetValue(contract.SharesOutstanding),
                SharesPercentSharesOut = GetShortenedValue(contract.SharesPercentSharesOut),
                SharesShort = GetValue(contract.SharesShort),
                SharesShortPreviousMonthDate = GetShortenedValue(contract.SharesShortPreviousMonthDate),
                SharesShortPriorMonth = GetValue(contract.SharesShortPriorMonth),
                ShortPercentOfFloat = GetShortenedValue(contract.ShortPercentOfFloat),
                ShortRatio = GetShortenedValue(contract.ShortRatio),
                ThreeYearAverageReturn = GetStub<ThreeYearAverageReturnStub>(),
                TotalAssets = GetStub<TotalAssetsStub>(),
                TrailingEps = GetShortenedValue(contract.TrailingEps),
                Yield = GetStub<YieldStub>(),
                YtdReturn = GetStub<YtdReturnStub>(),
                _52WeekChange = GetShortenedValue(contract._52WeekChange)
            };
        }

        private static T GetStub<T>() where T : class, new()
        {
            return new T();
        }

        private static IndexTrend GetIndexTrend(IndexTrendContract contract)
        {
            return new IndexTrend
            {
                Symbol = contract.Symbol,
                MaxAge = contract.MaxAge,
                PeRatio = GetShortenedValue(contract.PeRatio),
                PegRatio = GetShortenedValue(contract.PegRatio),
                Estimates = GetEstimated(contract.Estimates)
            };
        }

        private static IEnumerable<Estimate> GetEstimated(EstimateContract[] contractEstimates)
        {
            foreach (var c in contractEstimates)
            {
                yield return new Estimate
                {
                    Period = c.Period,
                    Growth = GetShortenedValue(c.Growth)
                };
            }
        }

        private static CashFlowStatementHistory GetCashflowStatementHistory(CashFlowStatementHistoryContract contract)
        {
            return new CashFlowStatementHistory
            {
                MaxAge = contract.MaxAge,
                CashFlowStatements = GetCashFlowStatements(contract.CashFlowStatements)
            };
        }

        private static IEnumerable<CashFlowStatement> GetCashFlowStatements(CashFlowStatementContract[] contractCashFlowStatements)
        {
            foreach (var c in contractCashFlowStatements)
            {
                yield return new CashFlowStatement
                {
                    MaxAge = c.MaxAge,
                    CapitalExpenditures = GetValue(c.CapitalExpenditures),
                    ChangeInCash = GetValue(c.ChangeInCash),
                    ChangeToAccountReceivables = GetValue(c.ChangeToAccountReceivables),
                    ChangeToInventory = GetValue(c.ChangeToInventory),
                    ChangeToLiabilities = GetValue(c.ChangeToLiabilities),
                    ChangeToNetIncome = GetValue(c.ChangeToNetIncome),
                    ChangeToOperatingActivities = GetValue(c.ChangeToOperatingActivities),
                    Depreciation = GetValue(c.Depreciation),
                    DividendsPaid = GetValue(c.DividendsPaid),
                    EffectOfExchangeRate = GetValue(c.EffectOfExchangeRate),
                    EndDate = GetShortenedValue(c.EndDate),
                    Investments = GetValue(c.Investments),
                    IssuanceOfStock = GetValue(c.IssuanceOfStock),
                    NetBorrowings = GetValue(c.NetBorrowings),
                    NetIncome = GetValue(c.NetIncome),
                    OtherCashFlowsFromFinancingActivities = GetValue(c.OtherCashFlowsFromFinancingActivities),
                    OtherCashFlowsFromInvestingActivities = GetValue(c.OtherCashFlowsFromInvestingActivities),
                    RepurchaseOfStock = GetValue(c.RepurchaseOfStock),
                    TotalCashFlowsFromInvestingActivities = GetValue(c.TotalCashFlowsFromInvestingActivities),
                    TotalCashFromFinancingActivities = GetValue(c.TotalCashFromFinancingActivities),
                    TotalCashFromOperatingActivities = GetValue(c.TotalCashFromOperatingActivities),
                };
            }
        }



        private static RecommendationTrend GetRecommendationTrend(RecommendationTrendContract contract)
        {
            if (contract == null)
                return null;

            return new RecommendationTrend
            {
                MaxAge = contract.MaxAge,
                Trend = GetTrend(contract.Trend)
            };
        }

        private static IEnumerable<Trend> GetTrend(TrendContract[] contractTrend)
        {
            foreach (var t in contractTrend)
            {
                yield return new Trend
                {
                    Buy = t.Buy,
                    Hold = t.Hold,
                    Period = t.Period,
                    Sell = t.Sell,
                    StrongBuy = t.StrongBuy,
                    StrongSell = t.StrongSell
                };
            }
        }

        private static AssetProfile GetAsseteProfile(AssetProfileContract contract)
        {
            if (contract == null)
                return null;

            return new AssetProfile
            {
                Address1 = contract.Address1,
                AuditRisk = contract.AuditRisk,
                BoardRisk = contract.BoardRisk,
                City = contract.City,
                CompanyOfficers = GetCompanyOfficers(contract.CompanyOfficers),
                MaxAge = contract.MaxAge,
                CompensationAsOfEpochDate = contract.CompensationAsOfEpochDate,
                CompensationRisk = contract.CompensationRisk,
                Country = contract.Country,
                FullTimeEmployees = contract.FullTimeEmployees,
                GovernanceEpochDate = contract.GovernanceEpochDate,
                Industry = contract.Industry,
                LongBusinessSummary = contract.LongBusinessSummary,
                OverallRisk = contract.OverallRisk,
                Phone = contract.Phone,
                Sector = contract.Sector,
                ShareHolderRightsRisk = contract.ShareHolderRightsRisk,
                State = contract.State,
                Website = contract.Website,
                Zip = contract.Zip
            };
        }

        private static IEnumerable<CompanyOfficer> GetCompanyOfficers(CompanyOfficerContract[] contract)
        {
            foreach (var c in contract)
            {
                yield return new CompanyOfficer
                {
                    Age = c.Age,
                    ExercisedValue = GetValue(c.ExercisedValue),
                    FiscalYear = c.FiscalYear,
                    MaxAge = c.MaxAge,
                    Name = c.Name,
                    Title = c.Title,
                    TotalPay = c.TotalPay != null ? GetValue(c.TotalPay) : null,
                    UnexercisedValue = GetValue(c.UnexercisedValue),
                    YearBorn = c.YearBorn
                };
            }
        }


        public static ShortenedValue GetShortenedValue(ShortenedValueContract value)
        {
            if (value == null)
                return null;

            return new ShortenedValue
            {
                Fmt = value.Fmt,
                Raw = value.Raw
            };
        }

        private static Value GetValue(ValueContract value)
        {
            if (value == null)
                return null;

            return new Value
            {
                Fmt = value.Fmt,
                LongFmt = value.LongFmt,
                Raw = value.Raw
            };
        }
    }
}
