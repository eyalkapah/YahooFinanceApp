using System;

namespace YahooFinance.Runner.Models.HistoricalData
{
    public class Meta
    {
        public string Currency { get; set; }

        public string Symbol { get; set; }

        public string ExchangeName { get; set; }

        public string InstrumentType { get; set; }

        public DateTime FirstTradeDate { get; set; }

        public DateTime RegularMarketTime { get; set; }

        //public int Gmtoffset { get; set; }

        //public string Timezone { get; set; }

        public string ExchangeTimezoneName { get; set; }

        public float RegularMarketPrice { get; set; }

        public int PriceHint { get; set; }

        public CurrentTradingPeriod CurrentTradingPeriod { get; set; }

        public string DataGranularity { get; set; }

    }
}
