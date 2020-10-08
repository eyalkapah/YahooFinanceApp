using System.Collections.Generic;

namespace AutoTrader.Models.Models.FundamentalData
{
    public class IncomeStatementHistory
    {
        public IEnumerable<IncomeStatementHistory1> IncomeStatementsHistory { get; set; }

        public int MaxAge { get; set; }
    }
}
