using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YahooFinance.Runner.Enums;
using YahooFinance.Runner.Helpers;
using YahooFinance.Runner.Models.HistoricalData;
using YahooFinance.Runner.Services;

namespace YahooFinance.Runner
{
    class Program
    {

        static async Task Main(string[] args)
        {
           var yfService = new YahooService();

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


           var prices = new List<Price>();

           await prices.ReadCsvAsync(@"C:\Temp\MSFT.csv");
            Console.ReadLine();
        }

     
    }
}
