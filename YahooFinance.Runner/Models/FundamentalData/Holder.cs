using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class Holder
    {
        public int MaxAge { get; set; }

        public string Name { get; set; }

        public string Relation { get; set; }

        public string Url { get; set; }

        public string TransactionDescription { get; set; }

        public ShortenedValue LatestTransDate { get; set; }

        public Value PositionDirect { get; set; }

        public ShortenedValue PositionDirectDate { get; set; }
    }
}
