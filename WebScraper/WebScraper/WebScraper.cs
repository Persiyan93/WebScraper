using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Web
{
    public class WebScraper<T> : IWebScraper
    {
        private string pattern;
        private string webSiteLink;
        private HttpClient client;

        public WebScraper(string link)
        {

            this.webSiteLink = link;
            this.client = new HttpClient();
            client.DefaultRequestHeaders.Add("user-agent",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64)" +
                " AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.82 Safari/537.36");
        }

        public async Task<byte[]> Start()
        {
            var response = await this.client.GetAsync(this.webSiteLink);
            var headers = response.Headers;
            var responseAsbyteArray = await response.Content.ReadAsByteArrayAsync();
            return responseAsbyteArray;




        }
        public void AddCookie(string name, string value)
        {
            this.client.DefaultRequestHeaders.Add(name, value);
        }


    }
}


           // var password = "533810060530606";
           // var userName = "П. Г. Георгиев";
           // var formContent = new FormUrlEncodedContent(new[]
           // {
           //      new KeyValuePair<string, string>("user", userName),
           //      new KeyValuePair<string, string>("pass", password)
           //  });

           //var responseFromForm=await  this.client.PostAsync("https://www3.speditor.net/cgi-bin/sl3", formContent);
           // var headersFromResponse = responseFromForm.Headers;
           // foreach (var header in headersFromResponse)
           // {
           //     Console.WriteLine(header.Key + "   " + header.Value);