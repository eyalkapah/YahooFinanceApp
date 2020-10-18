using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoTrader.Models.Models.HistoricalData;

namespace AutoTrader.Models.Models
{
    public class ExtremaPoint
    {
        public double Min { get; set; }

        public double Max { get; set; }

        public double Avg { get; set; }

        public List<Price> Prices { get; set; }
        public Guid Id { get; set; }

        public ExtremaPoint()
        {
            Id = Guid.NewGuid();

            Prices = new List<Price>();
        }
    }
}
