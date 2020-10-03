using System;
using System.Text.Json;
using System.Threading.Tasks;
using YahooFinance.Runner.Enums;
using YahooFinance.Runner.Helpers;
using YahooFinance.Runner.Models;
using YahooFinance.Runner.Models.Contracts.FundamentalData;
using YahooFinance.Runner.Models.Contracts.HistoricalData;
using YahooFinance.Runner.Models.FundamentalData;

namespace YahooFinance.Runner.Services
{
    public class YahooService
    {
        //public async Task<HistoricalData> GetHistoricalDataAsync(Frequency frequency, DateTime startTime,
        //    DateTime endTime, string symbol)
        //{
        //    var yfStartTime = startTime.ToUnixTimeSeconds();
        //    var yfEndTimeEpoch = endTime.ToUnixTimeSeconds();
        //    var yfFrequency = frequency.GetFrequencyString();

        //    var url =
        //        $"?frequency={yfFrequency}" +
        //        "&filter=history" +
        //        $"&period1={yfStartTime}" +
        //        $"&period2={yfEndTimeEpoch}" +
        //        $"&symbol={symbol}";

        //    var response = await HttpClientExtensions.HttpGetClient(url);

        //    var json = await response.Content.ReadAsStringAsync();

        //    var contract = JsonSerializer.Deserialize<HistoricalDataContract>(json);

        //    return contract.GetHistoricalData();
        //}

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

            var response = await HttpClientExtensions.HttpGetClientYahoo(url);

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
                $",majorHoldersBreakdown,balanceSheetHistory,majorDirectHolders,esgScores";

                      var response = await HttpClientExtensions.GetV10Client(url);

            var json = await response.Content.ReadAsStringAsync();

            var contract = JsonSerializer.Deserialize<FundamentalDataContract>(json);

            return contract.GetFundamentalData();
        }
    }
}
