namespace AutoTrader.Models.Models.FundamentalData
{
    public class Filing
    {
        public string Date { get; set; }

        public int EpochDate { get; set; }

        public string Type { get; set; }

        public string Title { get; set; }

        public string EdgarUrl { get; set; }

        public int MaxAge { get; set; }
    }
}
