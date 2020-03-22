using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BYSJ.Services
{
    public static class RestService
    {
        public static string GetToken(string username,string password)
        {
            HttpClient client = new HttpClient() { Timeout = TimeSpan.FromSeconds(30) };

            var content = new FormUrlEncodedContent(new Dictionary<string, string>() {
                        { "username",username },
                        { "password",password }

                    });
            var response = client.PostAsync(API_Info.GetTokenEndPoint, content);
            
            string token =  response.Result.Content.ReadAsStringAsync().Result;
            return token;
        }
    }
}
