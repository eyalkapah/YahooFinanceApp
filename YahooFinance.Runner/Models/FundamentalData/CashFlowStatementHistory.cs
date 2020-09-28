using System.Collections.Generic;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class CashFlowStatementHistory
    {
        public IEnumerable<CashFlowStatement> CashFlowStatements { get; set; }

        public int MaxAge { get; set; }
    }
}
