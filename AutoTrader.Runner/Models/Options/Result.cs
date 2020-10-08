using System.Collections.Generic;

namespace YahooFinance.Runner.Models.Options
{
    public class Result
    {
        public string UnderlyingSymbol { get; set; }

        public int[] ExpirationDates { get; set; }

        public float[] Strikes { get; set; }

        public bool HasMiniOptions { get; set; }

        public Quote Quote { get; set; }

        public IEnumerable<Option> Options { get; set; }
    }
}