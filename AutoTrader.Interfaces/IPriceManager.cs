using AutoTrader.Models.Enums;
using AutoTrader.Models.Models;
using AutoTrader.Models.Models.HistoricalData;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoTrader.Interfaces
{
    public interface IPriceManager
    {
        Task<IEnumerable<Price>> GetHistoricalDataAsync(Ticker ticker, int numOfDays);

        Task<List<Price>> GetPricesAsync(
            Ticker ticker,
            DateTime startTime,
            DateTime endTime,
            Interval frequency,
            bool includePrePost);

        List<Profit> CalculateProfits(IEnumerable<Price> prices);
        MomentumDetail CalculateMomentum(List<Price> prices, DateTime cutTime, int numOfStocks);
        List<MomentumDetail> SlidingWindow(List<Price> prices, int trainDays, int testDays, int numOfStocks);
        List<ExtremaGroup> GetSupportExtremaGroups(List<Price> prices, ExtremaType extremePoint, double offsetPercent);
        List<ExtremaGroup> GetRejectExtremaGroups(List<Price> prices, double offsetPercent);
        Dictionary<DayOfWeek, MomentumCount> GetDaysMomentum(List<Price> prices);
        List<double> Normalize(List<double> data);
    }
}
