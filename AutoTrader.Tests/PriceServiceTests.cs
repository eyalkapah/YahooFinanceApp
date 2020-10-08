using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoTrader.Models.Helpers;
using AutoTrader.Models.Models.HistoricalData;
using AutoTrader.Runner.Services;

namespace AutoTrader.Tests
{
    [TestClass]
    public class PriceServiceTests
    {
        private List<Price> _prices;
        private PriceManager _service;

        [TestInitialize]
        public void Initialize()
        {
            _service = new PriceManager();

            _prices = CsvExtensions.ReadCsvAsync(Constants.DataAllStocks5YrCsv, new Dictionary<string, string>
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
        [DataRow("MSFT", "2013-02-08", "2018-02-07", 227.64)]
        public void CalculateProfitsTest(string inStock, string outStartTime, string outEndTime, double outPercentage)
        {
            var profits = _service.CalculateProfits(_prices);

            var msft = profits.First(c => c.Symbol.Equals(inStock));

            Assert.AreEqual(msft.StartTime.Date, DateTime.Parse(outStartTime).Date, "Start time doesn't match");
            Assert.AreEqual(msft.EndTime.Date, DateTime.Parse(outEndTime).Date, "End time doesn't match");
            Assert.AreEqual(msft.ProfitPercentage, outPercentage, "Percentage doesn't match");
        }

        [DataTestMethod]
        [DataRow("2018-01-01", 50, 92.72, -1.23, 3.71)]
        public void CalculateMomentumTest(string inCutDate, int stockCount, double outTrainAverage, double outTestAverage, double outStocksToBuyAverage)
        {
            var momentumDetail = _service.CalculateMomentum(_prices, DateTime.Parse(inCutDate), stockCount);

            Assert.AreEqual(momentumDetail.TrainAverage, outTrainAverage, "Train average doesn't match");
            Assert.AreEqual(momentumDetail.TestAverage, outTestAverage, "Test average doesn't match");
            Assert.AreEqual(momentumDetail.StocksToBuyAverage, outStocksToBuyAverage, "Stocks to buy average doesn't match");
            Assert.AreEqual(momentumDetail.StocksToBuy.Count(), stockCount, "Stock count doesn't match");
        }

    }
}
