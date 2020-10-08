using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YahooFinance.Runner.Enums;
using YahooFinance.Runner.Helpers;
using YahooFinance.Runner.Models;
using YahooFinance.Runner.Models.HistoricalData;
using YahooFinance.Runner.Services;
using YahooFinance.Runner.Services.API;

namespace YahooFinance.Runner
{
    class Program
    {

        static async Task Main(string[] args)
        {
           var yfService = new YahooService();

           var symbol = "MSFT";



           //var result = await yfService.GetHistoricalDataAsync(Frequency.OneDay
           //    , new DateTime(2020, 9, 1, 12, 0, 0)
           //    , new DateTime(2020, 9, 25, 12, 0, 0)
           //    , "MSFT");

           //var result = await yfService.GetHistoricalDataAsyncYahoo(Interval.OneDay
           //    , new DateTime(2020, 9, 1, 12, 0, 0)
           //    , new DateTime(2020, 9, 25, 12, 0, 0)
           //    , "MSFT", true);


           //var fundamentalData = await yfService.GetFundamentalDataAsync("MSFT");

           //foreach (var result in fundamentalData.QuoteSummary.Result)
           //{
           //    //var assetProfile = result.AssetProfile;

           //    //foreach (var assetProfileCompanyOfficer in assetProfile.CompanyOfficers)
           //    //{
                   
           //    //}

           //    var recommendation = result.RecommendationTrend;

           //    foreach (var trend in recommendation.Trend)
           //    {
                   
           //    }

           //    var c = result.CashflowStatementHistory;

           //    foreach (var cCashFlowStatement in c.CashFlowStatements)
           //    {
                   
           //    }

           //    var i = result.IndexTrend;

           //    foreach (var iEstimate in i.Estimates)
           //    {
                   
           //    }

           //    var d = result.DefaultKeyStatistics;

           //    var it = result.IndustryTrend;

           //    var itt = result.IncomeStatementHistory;

           //    var fo = result.FundOwnership;

           //    var sd = result.SummaryDetail;

           //    var sdd = result.InsiderHolders;

           //    foreach (var sddHolder in sdd.Holders)
           //    {
                   
           //    }

           //    var sddd = result.CalendarEvents;

           //    var ds = result.UpgradeDowngradeHistory;

           //    var dd = result.BalanceSheetHistory;

           //    foreach (var ddBalanceSheetStatement in dd.BalanceSheetStatements)
           //    {
                   
           //    }
           //}

           //var hs = await yfService.GetHistoricalDataAsyncYahoo(Interval.OneDay, new DateTime(2010, 1, 1),
           //    new DateTime(2020, 1, 1), "MSFT", true);


           //await hs.Prices.WriteCsvAsync(@"c:\temp\MSFT.csv");

           //var options = await yfService.GetOptionsContractAsync("MSFT", DateTime.Now.AddDays(1));

           //var msftPrices = await yfService.GetHistoricalDataAsync("MSFT", 30);

            //var calcReturn = ((msftPrices.Last().Close - msftPrices.First().Open) / msftPrices.First().Open) * 100;

            var list = await yfService.CalculateReturnsAsync(new[] {"MSFT", "AAPL"}, 30);

            var sorted = list.Sort();

            var avg = list.Average();
            //list.GroupBy(c => symbol)

            //var prices = await yfService.GetHistoricalDataAsync(symbol, 30);

            //await prices.ToList().ReadCsvAsync(@"C:\Temp\MSFT.csv");
            // Console.ReadLine();

            var prices = await CsvExtensions.ReadCsvAsync("Data\\all_stocks_5yr.csv", new Dictionary<string, string>
            {
                {"date", "StartTime"},
                {"open", "Open"},
                {"high", "High"},
                {"low", "Low"},
                {"close", "Close"},
                {"volume", "Volume"},
                {"Name", "Symbol"}
            });

            //var momentum = prices.CalculateMomentum(new DateTime(2017, 1, 1), 50);

            //var stockNames = prices.GetStockNames();

            //var returns = prices.CalculateReturns();

            //var orderedReturns = returns.OrderBy(c => c.ReturnPercentage);

            //var m = prices.SlidingWindow(500, 300, 50);
        }

        private static double CalculateReturn(IGrouping<string, Price> grouped)
        {
            return Math.Round(((grouped.Last().Close - grouped.First().Open) / grouped.First().Open) * 100,2);
        }
    }
}
