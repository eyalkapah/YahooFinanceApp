using System;

namespace YahooFinance.Runner.Models
{
    public class Returns
    {
        public string Symbol { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public double ReturnPercentage { get; set; }
    }
}
