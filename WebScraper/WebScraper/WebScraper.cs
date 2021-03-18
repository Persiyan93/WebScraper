using System;
using System.Net.Http;

namespace Web
{
    public class WebScraper<T>:IWebScraper
    {
        private string pattern;
        private string webSiteLink;
        private HttpClient client;

        public WebScraper(string pattern,string link )
        {
            this.pattern = pattern;
            this.webSiteLink = link;
            this.client = new HttpClient();
        }

        public void Start()
        {

            
        }
    }
}
