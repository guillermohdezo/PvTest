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
            string stringResult = await Client.Post("Product/AddProduct", JsonConvert.SerializeObject(request));
            result = JsonConvert.DeserializeObject<SellResult>(stringResult);
            return result;
        }

        public async Task<SellResult> EditProduct(ProductModel request)
        {
            SellResult result = new SellResult();
            string stringResult = await Client.Post("product/EditProduct", JsonConvert.SerializeObject(request));
            result = JsonConvert.DeserializeObject<SellResult>(stringResult);
            return result;
        }

        public async Task<List<ProductModel>> GetProduct()
        {
            List<ProductModel> result = new List<ProductModel>();
            string stringResult = await Client.Get("product/getProduct");
            result = JsonConvert.DeserializeObject<List<ProductModel>>(stringResult);
            return result;
        }

        public async Task<List<DepResponce>> GetDep()
        {
            List<DepResponce> result = new List<DepResponce>();
            string stringResult = await Client.Get("product/getDep");
            result = JsonConvert.DeserializeObject<List<DepResponce>>(stringResult);
            return result;
        }
    }
}
