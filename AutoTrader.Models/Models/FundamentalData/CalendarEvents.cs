namespace AutoTrader.Models.Models.FundamentalData
{
    public class CalendarEvents
    {
        public int MaxAge { get; set; }

        public Earnings Earnings { get; set; }

        public ShortenedValue ExDividendDate { get; set; }

        public ShortenedValue DividendDate { get; set; }
    }
}
