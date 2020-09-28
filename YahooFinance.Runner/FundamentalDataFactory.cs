using System;
using System.Collections.Generic;
using YahooFinance.Runner.Models.Contracts.FundamentalData;
using YahooFinance.Runner.Models.FundamentalData;

namespace YahooFinance.Runner
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

                };
            }
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
            return new ShortenedValue
            {
                Fmt = value.Fmt,
                Raw = value.Raw
            };
        }

        private static Value GetValue(ValueContract value)
        {
            return new Value
            {
                Fmt = value.Fmt,
                LongFmt = value.LongFmt,
                Raw = value.Raw
            };
        }
    }
}
