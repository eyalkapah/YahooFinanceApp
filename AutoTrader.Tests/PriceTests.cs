using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YahooFinance.Runner.Helpers;
using YahooFinance.Runner.Models.HistoricalData;

namespace AutoTrader.Tests
{
    [TestClass]
    public class PriceTests
    {
        private List<Price> _prices;
        private const string DataAllStocksYrCsv = "Data\\all_stocks_5yr.csv";

        [TestInitialize]
        public void Initialize()
        {
            _prices = CsvExtensions.ReadCsvAsync(DataAllStocksYrCsv, new Dictionary<string, string>
            {
                {"date", "StartTime"},
                {"open", "Open"},
                {"high", "High"},
                {"low", "Low"},
                {"close", "Close"},
                {"volume", "Volume"},
                {"Name", "Symbol"}
            }).Result;

            Assert.IsNotNull(_prices, "Failed to read CSV file");
        }

        [DataTestMethod]
        [DataRow(505)]
        public void GetStockNamesTest(int stocksCount)
        {
            var stocks = _prices.GetStockNames();

            Assert.AreEqual(stocks.Count(), stocksCount, "Stock count is not equal");
        }

        [DataTestMethod]
        [DataRow("2013-02-08", "2018-02-07")]
        public void SortByStartTimeTest(string oldestDate, string latestDate)
        {
            var asc = _prices.SortByStartTime();

            // Ascending
            Assert.AreEqual(asc.First().StartTime.Date, DateTime.Parse(oldestDate), "Ascending oldest date not match");
            Assert.AreEqual(asc.Last().StartTime.Date, DateTime.Parse(latestDate), "Ascending latest date not match");

            var dsc = _prices.SortByStartTime(false);

            // Descending
            Assert.AreEqual(dsc.First().StartTime.Date, DateTime.Parse(latestDate), "Descending latest date not match");
            Assert.AreEqual(dsc.Last().StartTime.Date, DateTime.Parse(oldestDate), "Descending oldest date not match");
        }

        [DataTestMethod]
        [DataRow(false, "2015-01-02", 230835)]
        [DataRow(true, "2015-01-02", 231324)]
        public void TrimUntilTest(bool inIncludeEqual, string inCutDate, int outItemsCount)
        {
            var trimmed = _prices.TrimUntil(DateTime.Parse(inCutDate), inIncludeEqual);

            Assert.AreEqual(trimmed.Count, outItemsCount, "Trimmed items count not equal");
        }

        [DataTestMethod]
        [DataRow(false, "2015-01-02", 387705)]
        [DataRow(true, "2015-01-02", 388194)]
        public void TrimFromTest(bool inIncludeEqual, string inCutDate, int outItemsCount)
        {
            var trimmed = _prices.TrimFrom(DateTime.Parse(inCutDate), inIncludeEqual);

            Assert.AreEqual(trimmed.Count, outItemsCount, "Trimmed items count not equal");
        }

        [DataTestMethod]
        [DataRow(0, 2, 2, 2, new[] {"AAL", "AAPL", "AAP", "ABBV"})]
        public void ConcatStockNamesTest(int inList1StartIndex, int inList1ItemsCount, int inList2StartIndex,
            int inList2ItemsCount, string[] outStockNames)
        {
            var list = _prices.SortByStartTime();

            var list1 = list.GetRange(inList1StartIndex, inList1ItemsCount);
            var list2 = list.GetRange(inList2StartIndex, inList2ItemsCount);

            var stockNames = list1.ConcatStockNames(list2).ToList();

            CollectionAssert.AreEqual(stockNames, outStockNames, "Failed to concat price list");
        }

        [DataTestMethod]
        [DataRow(1825)]
        public void DaysCountTest(int outDaysCount)
        {
            var daysCount = _prices.DaysCount();

            Assert.AreEqual(daysCount, outDaysCount, "DaysCount doesn't match");
        }

        [DataTestMethod]
        [DataRow("2013-01-01", "2015-01-01", 230835)]
        public void BetweenDatesTest(string inStartTime, string inEndTime, int outItemsCount)
        {
            var prices = _prices.BetweenDates(DateTime.Parse(inStartTime), DateTime.Parse(inEndTime));

            Assert.AreEqual(prices.Count, outItemsCount, "Days count between dates don't match");
        }

    }
}
