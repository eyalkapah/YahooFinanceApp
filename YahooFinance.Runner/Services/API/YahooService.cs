using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AutoTrader.Yahoo.API;
using AutoTrader.Yahoo.API.Contracts.FundamentalData;
using AutoTrader.Yahoo.API.Contracts.HistoricalData;
using AutoTrader.Yahoo.API.Contracts.Options;
using YahooFinance.Runner.Enums;
using YahooFinance.Runner.Helpers;
using YahooFinance.Runner.Models;
using YahooFinance.Runner.Models.FundamentalData;
using YahooFinance.Runner.Models.HistoricalData;
using Price = YahooFinance.Runner.Models.HistoricalData.Price;

namespace YahooFinance.Runner.Services.API
{
    public class YahooService
    {
        private YahooClient _client;

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
            var result = await GetHistoricalDataAsyncYahoo(Interval.OneDay, DateTime.Now.AddDays(-2 * numOfDays),
                DateTime.Now, symbol, true);

            return result.Prices.TakeLast(numOfDays).OrderBy(c => c.StartTime);
        }

        public async Task<HistoricalData> GetHistoricalDataAsyncYahoo(Interval frequency, DateTime startTime,
            DateTime endTime, string symbol, bool includePrePost)
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

        public async Task<FundamentalData> GetFundamentalDataAsync(string symbol, params string[] modules)
        {
            var url =
                $"{symbol}?modules=assetProfile,recommendationTrend,cashflowStatementHistory" +
                $",indexTrend,defaultKeyStatistics,industryTrend,incomeStatementHistory" +
                $",fundOwnership,summaryDetail" +
                $",insiderHolders" +
                $",calendarEvents,upgradeDowngradeHistory,price,balanceSheetHistory" +
                $",earningsTrend,secFilings,institutionOwnership" +
                $",majorHoldersBreakdown,balanceSheetHistory,majorDirectHolders,esgScores" +
                $",summaryProfile,netSharePurchaseActivity,insiderTransactions" +
                $",incomeStatementHistoryQuarterly,cashflowStatementHistoryQuarterly" +
                $",financialData";

            var response = await _client.GetV10Client(url);

            var json = await response.Content.ReadAsStringAsync();

            var contract = JsonSerializer.Deserialize<FundamentalDataContract>(json);

            return contract.GetFundamentalData();
        }

        public async Task<Models.Options.Options> GetOptionsContractAsync(string symbol, DateTime date)
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
