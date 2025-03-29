using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CheckProg.Classes
{
    internal class SendToAPI
    {
        private string APIUrl { get; set; }
        private string defDir { get; set; }

        public void SetURL(string pth)
        {
            this.APIUrl = "https://localhost:7278/";
        }

        private HttpClient client;
        public HttpClient GetHttp()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        internal async Task<bool> SendData(string id, Dictionary<string, string> data)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            content.Headers.Add("id", id);
            HttpResponseMessage temp = await this.GetHttp().PostAsync($"{APIUrl}Data/GetData", content);
            if (temp.IsSuccessStatusCode) return true; 
            else return false;
        }
    }
}
