﻿using AutoTrader.Models.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AutoTrader.Yahoo.API
{
    public class YahooClient 
    {
        private const string OptionsUrl = "https://query2.finance.yahoo.com/v7/finance/options/";
        private const string QuoteSummaryUrl = "https://query1.finance.yahoo.com/v10/finance/quoteSummary/";
        private const string ChartUrl = "https://query1.finance.yahoo.com/v8/finance/chart/";

        public async Task<HttpResponseMessage> HttpGetClientYahoo(string url)
        {
            using var client = new HttpClient
            {
                BaseAddress = new Uri(ChartUrl)
            };

            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();

            return response;
        }

        public async Task<HttpResponseMessage> GetV10Client(string url)
        {
            using var client = new HttpClient
            {
                BaseAddress = new Uri(QuoteSummaryUrl)
            };

            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();

            return response;
        }

        public async Task<HttpResponseMessage> GetV7Client(string url)
        {
            using var client = new HttpClient
            {
                BaseAddress = new Uri(OptionsUrl)
            };

            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();

            return response;
        }
    }
}
