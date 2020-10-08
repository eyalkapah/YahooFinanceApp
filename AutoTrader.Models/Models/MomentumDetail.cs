using System.Collections.Generic;

namespace AutoTrader.Models.Models
{
    public class MomentumDetail
    {
        public IEnumerable<string> AllSymbols { get; set; }
        public double TrainAverage { get; set; }
        public double TestAverage { get; set; }
        public IEnumerable<string> StocksToBuy { get; set; }
        public double StocksToBuyAverage { get; set; }
    }
}
