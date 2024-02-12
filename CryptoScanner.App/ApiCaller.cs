using Newtonsoft.Json;

namespace CryptoScanner.App
{
    public class ApiCaller
    {
        public HttpClient Client { get; set; }

        public ApiCaller()
        {
            Client = new();
            Client.BaseAddress = new Uri("https://api.coingecko.com/api/v3/");
        }

        public async Task<CoinRoot> GetCrypto(string Url)
        {
            HttpResponseMessage response = await Client.GetAsync(Url);
            if (response.IsSuccessStatusCode)
            {
                string cryptoJson = await response.Content.ReadAsStringAsync();
                CoinRoot? result = JsonConvert.DeserializeObject<CoinRoot>(cryptoJson);

                if (result != null)
                {
                    // TODO: Add Cryptocurrency in ViewModel (OR PlaceHolder)
                    return result;
                }
            }
            throw new HttpRequestException("Could not deserialize Json.");
        }

        public async Task GetAllCrypto()
        {
            throw new NotImplementedException();
        }
    }
}
