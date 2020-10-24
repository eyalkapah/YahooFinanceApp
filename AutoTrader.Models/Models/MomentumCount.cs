using System;

namespace AutoTrader.Models.Models
{
    public class MomentumCount
    {
        public int UpCount { get; set; }
        public int DownCount { get; set; }

        public double UpCountPercent => Math.Round( (UpCount / (double)(UpCount + DownCount) * 100), 2);
        public double DownCountPercent => Math.Round((DownCount / (double)(UpCount + DownCount) * 100), 2);
        public double TotalRevenue { get; set; }
    }
}
