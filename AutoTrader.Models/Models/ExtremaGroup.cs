using AutoTrader.Models.Models.HistoricalData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoTrader.Models.Models
{
    public class ExtremaGroup : List<Price>
    {
        public Guid Id { get; set; }

        public double Average => Math.Round(this.Average(c => c.Close), 2);
        public double MinValue => Math.Round(this.Min(c => c.Close), 2);
        public double MaxValue => Math.Round(this.Max(c => c.Close), 2);

        public ExtremaGroup()
        {
            Id = Guid.NewGuid();
        }
    }
}
