using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AutoTrader.Models.Enums;
using AutoTrader.Models.Models;
using AutoTrader.Models.Models.FundamentalData;
using AutoTrader.Models.Models.HistoricalData;
using AutoTrader.Models.Models.Options;
using Price = AutoTrader.Models.Models.HistoricalData.Price;

namespace AutoTrader.Models.Interfaces
{
    public interface IStockDataService
    {
        Task<IEnumerable<Profit>> CalculateReturnsAsync(string[] symbols, int numOfDays);
        Task<IEnumerable<Price>> GetHistoricalDataAsync(string[] symbols, int numOfDays);
        Task<IEnumerable<Price>> GetHistoricalDataAsync(string symbol, int numOfDays);

        Task<HistoricalData> GetHistoricalDataAsync(
            string symbol,
            DateTime startTime,
            DateTime endTime,
            Interval frequency,
            bool includePrePost);

        Task<FundamentalData> GetFundamentalDataAsync(string symbol, bool assetProfile = false,
            bool recommendationTrend = false, bool cashflowStatementHistory = false,
            bool indexTrend = false, bool defaultKeyStatistics = false, bool industryTrend = false, bool incomeStatementHistory = false,
            bool fundOwnership = false, bool summaryDetail = false, bool insiderHolders = false, bool calendarEvents = false,
            bool upgradeDowngradeHistory = false, bool price = false,
            bool earningsTrend = false, bool secFilings = false, bool institutionOwnership = false, bool majorHoldersBreakdown = false,
            bool balanceSheetHistory = false, bool majorDirectHolders = false, bool esgScores = false,
            bool summaryProfile = false, bool netSharePurchaseActivity = false, bool insiderTransactions = false,
            bool incomeStatementHistoryQuarterly = false, bool cashflowStatementHistoryQuarterly = false,
            bool financialData = false);

        Task<Options> GetOptionsContractAsync(string symbol, DateTime date);
    }
}
