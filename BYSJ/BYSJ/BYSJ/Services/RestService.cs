using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using BYSJ.Models;

namespace BYSJ.Services
{
    public static class RestService
    {
        public static async Task<string> GetToken(string username,string password)
        {
            HttpClient client = new HttpClient(GetHandler()) { Timeout = TimeSpan.FromSeconds(30) };

            user User = new user
            {
                username = username,
                password = password
            };
            var json = JsonConvert.SerializeObject(User);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(API_Info.GetTokenEndPoint, content);

            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
        public static async Task<List<repairRecord>> GetUnfinishedRecord()
        {
            HttpClient client = new HttpClient(GetHandler()) { Timeout = TimeSpan.FromSeconds(30) };
            var response = await client.GetAsync(API_Info.GetUnfinishedRecord);
            var content = await response.Content.ReadAsStringAsync();
            var Items = JsonConvert.DeserializeObject<List<repairRecord>>(content);
            return Items;
        }

        static HttpClientHandler GetHandler()
        {
            var httpclientHandler = new HttpClientHandler();
            httpclientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, error) => true;
            return httpclientHandler;
        }

    }
}
