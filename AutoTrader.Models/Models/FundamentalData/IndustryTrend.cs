﻿using AutoTrader.Models.Models.FundamentalData.Stubs;

namespace AutoTrader.Models.Models.FundamentalData
{
    public class IndustryTrend
    {
        public int MaxAge { get; set; }

        public object Symbol { get; set; }

        public PeRatio1Stub PeRatio { get; set; }

        public PegRatio2Stub PegRatio { get; set; }

        public object[] Estimates { get; set; }
    }
}
