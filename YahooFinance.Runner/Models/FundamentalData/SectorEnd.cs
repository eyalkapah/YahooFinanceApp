using YahooFinance.Runner.Models.FundamentalData.Stubs;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class SectorEnd
    {
        public int MaxAge { get; set; }

        public object Symbol { get; set; }

        public PeRatio2Stub PeRatio { get; set; }

        public PegRatio3Stub PegRatio { get; set; }

        public object[] Estimates { get; set; }
    }
}
