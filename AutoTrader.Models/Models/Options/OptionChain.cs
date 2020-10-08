using System.Collections.Generic;

namespace AutoTrader.Models.Models.Options
{
    public class OptionChain
    {
        public IEnumerable<Result> Result { get; set; }

        public object Error { get; set; }
    }
}