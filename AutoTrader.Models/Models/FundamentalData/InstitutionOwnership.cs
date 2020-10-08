using System.Collections.Generic;

namespace AutoTrader.Models.Models.FundamentalData
{
    public class InstitutionOwnership
    {
        public int MaxAge { get; set; }

        public IEnumerable<OwnershipList1> OwnershipList { get; set; }
    }
}
