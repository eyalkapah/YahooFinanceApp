using System.Collections.Generic;

namespace AutoTrader.Models.Models.FundamentalData
{
    public class FundOwnerShip
    {
        public int MaxAge { get; set; }

        public IEnumerable<OwnerShipList> OwnershipList { get; set; }
    }
}
