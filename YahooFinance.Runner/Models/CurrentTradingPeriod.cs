using YahooFinance.Runner.Models.Contracts.HistoricalData;

namespace YahooFinance.Runner.Models
{
    public class CurrentTradingPeriod
    {
        public TradingPeriod Pre { get; set; }

        public TradingPeriod Regular { get; set; }

        public TradingPeriod Post { get; set; }
    }
}