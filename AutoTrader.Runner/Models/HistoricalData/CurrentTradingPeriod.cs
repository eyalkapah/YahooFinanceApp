namespace YahooFinance.Runner.Models.HistoricalData
{
    public class CurrentTradingPeriod
    {
        public TradingPeriod Pre { get; set; }

        public TradingPeriod Regular { get; set; }

        public TradingPeriod Post { get; set; }
    }
}