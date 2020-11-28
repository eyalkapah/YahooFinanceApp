using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoTrader.Models.Models.HistoricalData;
using AutoTrader.Runner.Oscillators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoTrader.Tests
{
    [TestClass]
    public class StochasticTests
    {
        private StochasticService _stochasticService;
        private List<Price> _prices;

        [TestInitialize]
        public void Initialize()
        {
            _stochasticService = new StochasticService();

            _prices = GetData();
        }

        [TestMethod]
        public void StochasticTest()
        {
            var data = _stochasticService.Run(_prices);

            Assert.AreEqual(data.First().High, 128.43f, "Highest doesn't match");
            Assert.AreEqual(data.First().Low, 124.56f, "Lowest doesn't match");
            Assert.AreEqual(data.First().Close, 127.29f, "Close doesn't match");
            Assert.AreEqual(data.First().Value, 70.54, "Value doesn't match");
            Assert.AreEqual(data.Last().High, 130.06f, "Highest doesn't match");
            Assert.AreEqual(data.Last().Low, 125.92f, "Lowest doesn't match");
            Assert.AreEqual(data.Last().Close, 128.27f, "Close doesn't match");
            Assert.AreEqual(data.Last().Value, 56.76, "Value doesn't match");
        }

        [TestMethod]
        public void SlowStochasticTest()
        {
            var data = _stochasticService.Run(_prices);

            for (var i = 3; i < data.Count; i++)
            {
                data[i].SlowValue = data.TakeLast(3).Average(c => c.Value);
            }

            Assert.AreEqual(data.First().SlowValue, default, "Slow stochastic should be NaN");
            Assert.AreEqual(data.Last().SlowValue, 54.75, "Slow stochastic value doesn't match");
           
        }

        public List<Price> GetData()
        {
            return new List<Price>
            {
                new Price
                {
                    StartTime = new DateTime(10, 2, 23),
                    High = 127.01f,
                    Low = 125.36f,
                },
                new Price
                {
                    StartTime = new DateTime(10, 2, 24),
                    High = 127.62f,
                    Low = 126.16f,
                },
                new Price
                {
                    StartTime = new DateTime(10, 2, 25),
                    High = 126.59f,
                    Low = 124.93f,
                },
                new Price
                {
                    StartTime = new DateTime(10, 2, 26),
                    High = 127.35f,
                    Low = 126.09f,
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 1),
                    High = 128.17f,
                    Low = 126.82f,
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 2),
                    High = 128.43f,
                    Low = 126.48f,
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 3),
                    High = 127.37f,
                    Low = 126.03f,
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 4),
                    High = 126.42f,
                    Low = 124.83f,
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 5),
                    High = 126.90f,
                    Low = 126.39f,
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 8),
                    High = 126.85f,
                    Low = 125.72f,
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 9),
                    High = 125.65f,
                    Low = 124.56f,
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 10),
                    High = 125.72f,
                    Low = 124.57f,
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 11),
                    High = 127.16f,
                    Low = 125.07f,
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 12),
                    High = 127.72f,
                    Low = 126.86f,
                    Close = 127.29f
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 15),
                    High = 127.69f,
                    Low = 126.63f,
                    Close = 127.18f
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 16),
                    High = 128.22f,
                    Low = 126.80f,
                    Close = 128.01f
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 17),
                    High = 128.27f,
                    Low = 126.71f,
                    Close = 127.11f
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 18),
                    High = 128.09f,
                    Low = 126.8f,
                    Close = 127.73f
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 19),
                    High = 128.27f,
                    Low = 126.13f,
                    Close = 127.06f
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 22),
                    High = 127.74f,
                    Low = 125.92f,
                    Close = 127.33f
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 23),
                    High = 128.77f,
                    Low = 126.99f,
                    Close = 128.71f
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 24),
                    High = 129.29f,
                    Low = 127.81f,
                    Close = 127.87f
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 25),
                    High = 130.06f,
                    Low = 128.47f,
                    Close = 128.58f
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 26),
                    High = 129.12f,
                    Low = 128.06f,
                    Close = 128.6f
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 29),
                    High = 129.29f,
                    Low = 127.61f,
                    Close = 127.93f
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 30),
                    High = 128.47f,
                    Low = 127.6f,
                    Close = 128.11f
                },
                new Price
                {
                    StartTime = new DateTime(10, 3, 31),
                    High = 128.09f,
                    Low = 127.00f,
                    Close = 127.6f
                },
                new Price
                {
                    StartTime = new DateTime(10, 4, 1),
                    High = 128.65f,
                    Low = 126.9f,
                    Close = 127.6f
                },
                new Price
                {
                    StartTime = new DateTime(10, 4, 5),
                    High = 129.14f,
                    Low = 127.49f,
                    Close = 128.69f
                },
                new Price
                {
                    StartTime = new DateTime(10, 4, 6),
                    High = 128.64f,
                    Low = 127.4f,
                    Close = 128.27f
                },
            };
        }
    }
}
