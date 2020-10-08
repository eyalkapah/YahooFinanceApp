namespace AutoTrader.Models.Models.FundamentalData
{
    public class Quarterly
    {
        public string Date { get; set; }

        public ShortenedValue Actual { get; set; }

        public ShortenedValue Estimate { get; set; }
    }
}
