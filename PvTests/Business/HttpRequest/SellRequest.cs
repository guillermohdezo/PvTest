using Newtonsoft.Json;
using PvTests.Business.Http;
using PvTests.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvTests.Business.HttpRequest
{
    public class SellRequest
    {
        HttpClientRest Client;

        public SellRequest()
        {
            Client = new HttpClientRest();
        }

        public async Task<SellResult> AddSell(SellModel request)
        {
            SellResult result = new SellResult();
            string stringResult = await Client.Post("sell/addSell", JsonConvert.SerializeObject(request));
            result = JsonConvert.DeserializeObject<SellResult>(stringResult);
            return result;
        }

        public async Task<SellListResult> GetSell()
        {
            SellListResult result = new SellListResult();
            string stringResult = await Client.Get("sell/getSell");
            result = JsonConvert.DeserializeObject<SellListResult>(stringResult);
            return result;
        }
    }
}
