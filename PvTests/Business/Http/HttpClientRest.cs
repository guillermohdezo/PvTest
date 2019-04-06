using PvTests.Models.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PvTests.Business.Http
{
    public class HttpClientRest
    {
        HttpClient Client;

        public HttpClientRest()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri(ConnectionProp.UrlService);
        }

        public async Task<string> Post(string url, string data)
        {
            string result = "";
            StringContent stringContent = new StringContent(data, Encoding.UTF8, "application/json");
            var httpResponse = await Client.PostAsync(url, stringContent);
            result = await httpResponse.Content.ReadAsStringAsync();
            return result;
        }

        public async Task<string> Get(string url)
        {
            string result = "";
            var httpResponse = await Client.GetAsync(url);
            result = await httpResponse.Content.ReadAsStringAsync();
            return result;
        }
    }
}
