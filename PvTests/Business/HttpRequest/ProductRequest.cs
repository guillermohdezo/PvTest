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
    public class ProductRequest
    {
        HttpClientRest Client;

        public ProductRequest()
        {
            Client = new HttpClientRest();
        }

        public async Task<SellResult> AddProduct(ProductModel request)
        {
            SellResult result = new SellResult();
            string stringResult = await Client.Post("sell/addProduct", JsonConvert.SerializeObject(request));
            result = JsonConvert.DeserializeObject<SellResult>(stringResult);
            return result;
        }

        public async Task<SellResult> EditProduct(ProductModel request)
        {
            SellResult result = new SellResult();
            string stringResult = await Client.Post("sell/addProduct", JsonConvert.SerializeObject(request));
            result = JsonConvert.DeserializeObject<SellResult>(stringResult);
            return result;
        }

        public async Task<ProductModel> GetProduct()
        {
            ProductModel result = new ProductModel();
            string stringResult = await Client.Get("sell/getProduct");
            result = JsonConvert.DeserializeObject<ProductModel>(stringResult);
            return result;
        }
    }
}
