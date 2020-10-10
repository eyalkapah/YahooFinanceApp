using AutoTrader.Models.Models.HistoricalData;
using System.Collections.Generic;

namespace AutoTrader.Models.Models
{
    public class FocusPoint
    {
        private readonly double _offsetPercent;
        
        public List<Price> Prices { get; set; }
        public Price CurrentPrice { get; set; }

        public double Offset => CurrentPrice.Close * _offsetPercent / 100;
        public double UpperZone => CurrentPrice.Close + Offset;
        public double LowerZone => CurrentPrice.Close - Offset;

        // C'tor
        //
        public FocusPoint(Price currentPrice, double offsetPercent)
        {
            Prices = new List<Price>();

            _offsetPercent = offsetPercent;

            CurrentPrice = currentPrice;
        }
    }
}
