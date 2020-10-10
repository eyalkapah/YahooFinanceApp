using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AutoTrader.Models.Enums;
using AutoTrader.Models.Models;
using AutoTrader.Models.Models.FundamentalData;
using AutoTrader.Models.Models.HistoricalData;
using AutoTrader.Models.Models.Options;
using Price = AutoTrader.Models.Models.HistoricalData.Price;

namespace AutoTrader.Models.Interfaces
{
    public interface IStockDataService
    {
        Task<IEnumerable<Profit>> CalculateReturnsAsync(string[] symbols, int numOfDays);
        Task<IEnumerable<Price>> GetHistoricalDataAsync(string[] symbols, int numOfDays);
        Task<IEnumerable<Price>> GetHistoricalDataAsync(string symbol, int numOfDays);

        Task<HistoricalData> GetHistoricalDataAsync(
            string symbol,
            DateTime startTime,
            DateTime endTime,
            Interval frequency,
            bool includePrePost);

        Task<FundamentalData> GetFundamentalDataAsync(string symbol, params string[] modules);
        Task<Options> GetOptionsContractAsync(string symbol, DateTime date);
    }
}
