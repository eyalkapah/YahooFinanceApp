using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class NetSharePurchaseActivity
    {
        public int MaxAge { get; set; }

        public string Period { get; set; }

        public Value BuyInfoCount { get; set; }

        public Value BuyInfoShares { get; set; }

        public ShortenedValue BuyPercentInsiderShares { get; set; }

        public Value SellInfoCount { get; set; }

        public Value SellInfoShares { get; set; }

        public ShortenedValue SellPercentInsiderShares { get; set; }

        public Value NetInfoCount { get; set; }

        public Value NetInfoShares { get; set; }

        public ShortenedValue NetPercentInsiderShares { get; set; }

        public Value TotalInsiderShares { get; set; }
    }
}
