using System;
using AutoTrader.Models.Models.HistoricalData;

namespace AutoTrader.Runner
{
    public class StochasticPrice
    {
        public DateTime StartTime { get; set; }
        public float High { get; set; }
        public float Low { get; set; }
        public float Close { get; set; }
        public double Value => Math.Round((((Close - Low) / (High - Low)) * 100),2);
        public Price Price { get; set; }
        public double SlowValue { get; set; }
    }
}
