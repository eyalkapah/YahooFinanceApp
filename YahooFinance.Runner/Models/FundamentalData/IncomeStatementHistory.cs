using System.Collections.Generic;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class IncomeStatementHistory
    {
        public IEnumerable<IncomeStatementHistory1> IncomeStatementsHistory { get; set; }

        public int MaxAge { get; set; }
    }
}
