using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinance.Runner.Models.Contracts.HistoricalData;

namespace YahooFinance.Runner.Models
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
