using System.Collections.Generic;

namespace AutoTrader.Models.Models.FundamentalData
{
    public class IncomeStatementHistoryQuarterly
    {
        public IEnumerable<IncomeStatementHistory1> IncomeStatementHistory { get; set; }

        public int MaxAge { get; set; }
    }
}
