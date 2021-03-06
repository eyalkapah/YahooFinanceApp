﻿using System;

namespace AutoTrader.Models.Models
{
    public class Profit
    {
        public string Symbol { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public double ProfitPercentage { get; set; }

        public int Rank { get; set; }
    }
}
