using System;
using AutoTrader.Models.Models.HistoricalData;
using System.Collections.Generic;

namespace AutoTrader.Models.Models
{
    public class Extrema
    {
        private readonly double _offsetPercent;

        public List<Price> Prices { get; set; }
        public Price CurrentPrice { get; set; }

        public double Offset => CurrentPrice.Close * _offsetPercent / 100;
        public double UpperZone { get; set; }
        public double LowerZone { get; set; }
        public Guid Id { get; set; }

        // C'tor
        //
        public Extrema(Price currentPrice, double offsetPercent)
        {
            Id = Guid.NewGuid();

            Prices = new List<Price>();

            _offsetPercent = offsetPercent;

            CurrentPrice = currentPrice;

            UpperZone = CurrentPrice.Close + Offset;
            LowerZone = CurrentPrice.Close - Offset;
        }
    }
}
