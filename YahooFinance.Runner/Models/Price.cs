using System;

namespace YahooFinance.Runner.Models
{
    public class Price
    {
        public DateTime StartTime { get; set; }
        public float Open { get; set; }
        public float Low { get; set; }
        public float High { get; set; }
        public float Close { get; set; }
        public double Volume { get; set; }
        public float AdjClose { get; set; }
        public float Dividends { get; set; }
        public int StockSplits { get; set; }
    }
}
