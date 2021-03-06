﻿using AutoTrader.Models.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AutoTrader.Tests
{
    [TestClass]
    public class CsvExtensionsTests
    {
        [DataTestMethod]
        [DataRow(505)]
        public void ReadConstituentsAsyncTest(int outStockCount)
        {
            var tickers = CsvExtensions.ReadConstituents(Constants.DataConstituentsCsv, new Dictionary<string, string>
            {
                {"Symbol", "Symbol"},
                {"Name", "Name"},
                {"Sector", "Sector"},
            });

            Assert.AreEqual(tickers.Count, outStockCount, "Stock count doesn't match");
        }
    }
}
