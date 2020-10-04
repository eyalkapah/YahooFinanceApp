using System.Collections.Generic;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class IncomeStatementHistoryQuarterly
    {
        public IEnumerable<IncomeStatementHistory1> IncomeStatementHistory { get; set; }

        public int MaxAge { get; set; }
    }
}
