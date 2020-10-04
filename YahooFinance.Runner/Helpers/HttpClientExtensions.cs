using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace YahooFinance.Runner.Helpers
{
    public static class HttpClientExtensions
    {
        private static readonly string _xRapidapiHost = "x-rapidapi-host";
        private static readonly string _xRapidapiKey = "x-rapidapi-key";

        private static readonly string _rapidApiBaseAddress =
            "https://apidojo-yahoo-finance-v1.p.rapidapi.com/stock/v2/get-historical-data";

        public static async Task<HttpResponseMessage> HttpGetClient(string url)
        {
            using var client = new HttpClient
            {
                BaseAddress = new Uri(_rapidApiBaseAddress)
            };

            client.DefaultRequestHeaders.Add(_xRapidapiHost, "apidojo-yahoo-finance-v1.p.rapidapi.com");
            client.DefaultRequestHeaders.Add(_xRapidapiKey, "24d3dd6db9mshe7a96eb6693658ep137f52jsne0116e593d82");

            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();

            return response;
        }

        public static async Task<HttpResponseMessage> HttpGetClientYahoo(string url)
        {
            using var client = new HttpClient
            {
                BaseAddress = new Uri("https://query1.finance.yahoo.com/v8/finance/chart/")
            };

            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();

            return response;
        }

        public static async Task<HttpResponseMessage> GetV10Client(string url)
        {
            using var client = new HttpClient
            {
                BaseAddress = new Uri("https://query1.finance.yahoo.com/v10/finance/quoteSummary/")
            };

            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();

            return response;
        }

        public static async Task<HttpResponseMessage> GetV7Client(string url)
        {
            using var client = new HttpClient
            {
                BaseAddress = new Uri("https://query2.finance.yahoo.com/v7/finance/options/")
            };

            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();

            return response;
        }

    }
}
