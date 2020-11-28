using AutoTrader.Models.Enums;
using AutoTrader.Models.Helpers;
using AutoTrader.Models.Models;
using AutoTrader.Models.Models.FundamentalData;
using AutoTrader.Models.Models.HistoricalData;
using AutoTrader.Models.Models.Options;
using AutoTrader.Yahoo.API.Contracts.FundamentalData;
using AutoTrader.Yahoo.API.Contracts.HistoricalData;
using AutoTrader.Yahoo.API.Contracts.Options;
using AutoTrader.Yahoo.API.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AutoTrader.Interfaces;
using Price = AutoTrader.Models.Models.HistoricalData.Price;

namespace AutoTrader.Yahoo.API
{
    public class YahooService : IStockDataService
    {
        private readonly YahooClient _client;

        public YahooService()
        {
            _client = new YahooClient();
        }

        public async Task<IEnumerable<Profit>> CalculateReturnsAsync(string[] symbols, int numOfDays)
        {
            var data = await GetHistoricalDataAsync(symbols, numOfDays);

            var groupedList = data.GroupBy(c => c.Symbol);

            var list = new List<Profit>();

            foreach (var grouped in groupedList)
            {
                list.Add(new Profit
                {
                    Symbol = grouped.Key,
                    StartTime = grouped.First().StartTime,
                    EndTime = grouped.Last().StartTime,
                    ProfitPercentage =
                        Math.Round(((grouped.Last().Close - grouped.First().Open) / grouped.First().Open) * 100, 2)
                });
            }

            return list;
        }

        public async Task<IEnumerable<Price>> GetHistoricalDataAsync(string[] symbols, int numOfDays)
        {
            var list = new List<Price>();

            foreach (var symbol in symbols)
            {
                var entries = await GetHistoricalDataAsync(symbol, numOfDays);

                list.AddRange(entries);
            }

            return list;
        }

        public async Task<IEnumerable<Price>> GetHistoricalDataAsync(string symbol, int numOfDays)
        {
            var result = await GetHistoricalDataAsync(
                symbol, 
                DateTime.Now.AddDays(-2 * numOfDays),
                DateTime.Now, 
                Interval.OneDay, 
                true);

            return result.Prices.TakeLastOf(numOfDays).OrderBy(c => c.StartTime);
        }

        public async Task<HistoricalData> GetHistoricalDataAsync(
            string symbol,
            DateTime startTime,
            DateTime endTime,
            Interval frequency,
            bool includePrePost)
        {
            var yStartTime = startTime.ToUnixTimeSeconds();
            var yEndTimeEpoch = endTime.ToUnixTimeSeconds();
            var yInterval = frequency.GetIntervalString();

            var url = $"{symbol}" +
                      $"?symbol={symbol}" +
                      $"&period1={yStartTime}" +
                      $"&period2={yEndTimeEpoch}" +
                      $"&interval={yInterval}" +
                      $"&includePrePost={includePrePost}" +
                      "&events=div%2Csplit";

            //var url =
            //    $"?frequency={yfFrequency}" +
            //    "&filter=history" +
            //    $"&period1={yfStartTime}" +
            //    $"&period2={yfEndTimeEpoch}" +
            //    $"&symbol={symbol}";

            var response = await _client.HttpGetClientYahoo(url);

            var json = await response.Content.ReadAsStringAsync();

            var contract = JsonSerializer.Deserialize<HistoricalDataContract>(json);

            return contract.GetHistoricalData();
            //return contract.GetHistoricalData();
        }

        public async Task<FundamentalData> GetFundamentalDataAsync(string symbol, bool assetProfile,
            bool recommendationTrend, bool cashflowStatementHistory,
            bool indexTrend, bool defaultKeyStatistics, bool industryTrend, bool incomeStatementHistory,
            bool fundOwnership, bool summaryDetail, bool insiderHolders, bool calendarEvents,
            bool upgradeDowngradeHistory, bool price,
            bool earningsTrend, bool secFilings, bool institutionOwnership, bool majorHoldersBreakdown,
            bool balanceSheetHistory, bool majorDirectHolders, bool esgScores,
            bool summaryProfile, bool netSharePurchaseActivity, bool insiderTransactions,
            bool incomeStatementHistoryQuarterly, bool cashflowStatementHistoryQuarterly,
            bool financialData)
        {
            var builder = new List<string>();

            builder.AddModule(nameof(assetProfile), assetProfile);
            builder.AddModule(nameof(recommendationTrend), recommendationTrend);
            builder.AddModule(nameof(cashflowStatementHistory), cashflowStatementHistory);
            builder.AddModule(nameof(indexTrend), indexTrend);
            builder.AddModule(nameof(defaultKeyStatistics), defaultKeyStatistics);
            builder.AddModule(nameof(industryTrend), industryTrend);
            builder.AddModule(nameof(incomeStatementHistory), incomeStatementHistory);
            builder.AddModule(nameof(fundOwnership), fundOwnership);
            builder.AddModule(nameof(summaryDetail), summaryDetail);
            builder.AddModule(nameof(insiderHolders), insiderHolders);
            builder.AddModule(nameof(calendarEvents), calendarEvents);
            builder.AddModule(nameof(upgradeDowngradeHistory), upgradeDowngradeHistory);
            builder.AddModule(nameof(price), price);
            builder.AddModule(nameof(earningsTrend), earningsTrend);
            builder.AddModule(nameof(secFilings), secFilings);
            builder.AddModule(nameof(institutionOwnership), institutionOwnership);
            builder.AddModule(nameof(majorHoldersBreakdown), majorHoldersBreakdown);
            builder.AddModule(nameof(balanceSheetHistory), balanceSheetHistory);
            builder.AddModule(nameof(majorDirectHolders), majorDirectHolders);
            builder.AddModule(nameof(esgScores), esgScores);
            builder.AddModule(nameof(summaryProfile), summaryProfile);
            builder.AddModule(nameof(netSharePurchaseActivity), netSharePurchaseActivity);
            builder.AddModule(nameof(insiderTransactions), insiderTransactions);
            builder.AddModule(nameof(incomeStatementHistoryQuarterly), incomeStatementHistoryQuarterly);
            builder.AddModule(nameof(cashflowStatementHistoryQuarterly), cashflowStatementHistoryQuarterly);
            builder.AddModule(nameof(financialData), financialData);

            var modules = string.Join(",", builder);

            var url = $"{symbol}?modules={modules}";

            var response = await _client.GetV10Client(url);

            var json = await response.Content.ReadAsStringAsync();

            var contract = JsonSerializer.Deserialize<FundamentalDataContract>(json);

            return contract.GetFundamentalData();
        }

        public async Task<Options> GetOptionsContractAsync(string symbol, DateTime date)
        {
            var url = symbol;

            var epochTime = decimal.MinValue;

            if (date > DateTime.Now.Date)
            {
                epochTime = date.ToUnixTimeSeconds();
            }

            if (epochTime != long.MinValue)
            {
                url = $"{url}?date={epochTime}";
            }

            var response = await _client.GetV7Client(url);

            var json = await response.Content.ReadAsStringAsync();

            var contract = JsonSerializer.Deserialize<OptionsContract>(json);

            return contract.GetOptions();
        }
    }
}
