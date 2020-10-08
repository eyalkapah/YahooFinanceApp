using System.Collections.Generic;

namespace YahooFinance.Runner.Models.Options
{
    public class Option
    {
        public int ExpirationDate { get; set; }

        public bool HasMiniOptions { get; set; }

        public IEnumerable<Call> Calls { get; set; }

        public IEnumerable<Put> Puts { get; set; }
    }
}