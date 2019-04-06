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
    public class LoginRequest
    {
        HttpClientRest Client;

        public LoginRequest()
        {
            Client = new HttpClientRest();
        }

        public async Task<LoginResponce> LoginCheck(string userName)
        {
            LoginResponce result = new LoginResponce();
            string stringResult = await Client.Post("login/checkLogin", $"{{ \"UserName\":\"{userName}\" }}");
            result = JsonConvert.DeserializeObject<LoginResponce>(stringResult);
            return result;
        }
    }
}
