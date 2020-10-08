namespace AutoTrader.Models.Models.FundamentalData
{
    public class Trend
    {
        public string Period { get; set; }

        public int StrongBuy { get; set; }

        public int Buy { get; set; }

        public int Hold { get; set; }

        public int Sell { get; set; }

        public int StrongSell { get; set; }
    }
}
