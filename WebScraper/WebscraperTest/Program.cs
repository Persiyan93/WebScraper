using System;
using Web;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Collections.Generic;
using WebScraper.Data;

namespace WebscraperTest
{
    public  class Program
    {
        static async Task Main(string[] args)
        {
          
            var context=new ApplicationDbContext
            var scraper = new WebScraper<Object>("https://www3.speditor.net/cgi-bin/borsa.pl?act=shc&cat=tovar");
            scraper.AddCookie("cookie", "webcookie=yes; bcnt=50; SpeditorLogin=%CF%2E%20%C3%2E%20%C3%E5%EE%F0%E3%E8%E5%E2!1629984322; sess=1629984322.787402537126259323; trq2=01629984253073497453177076863323344026475179367031");
            var enc1251 = CodePagesEncodingProvider.Instance.GetEncoding(1251);
            var responseAsByte=await scraper.Start();
            var result = enc1251.GetString(responseAsByte);

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(result);
            var listWithFreights = new List<Freight>();

            //var htmlNodes = htmlDoc.DocumentNode.ChildNodes;
            var htmlNodes = htmlDoc.DocumentNode.SelectNodes("//tr");
            foreach (var node in htmlNodes)
            {
                if (node.Attributes["id"] == null)
                {
                    continue;
                }
                else
                {
                    var freight = new Freight();
                    freight.Id = node.Attributes["id"].Value;
                    freight.AdditionalInfo = node.SelectSingleNode("./td[2]/a").Attributes["ttitle"].Value;
                    freight.LoadingAddress = node.SelectSingleNode("./td[2]/a/u/span[1]/b").InnerText;
                    freight.UnloadingAddress = node.SelectSingleNode("./td[2]/a/u/span[2]/b").InnerText;
                    freight.PostedOn = node.SelectSingleNode("./td[3]").InnerText;
                    freight.DateOfLoading = node.SelectSingleNode("./td[4]/b").InnerText;
                    freight.CountOfViews = int.Parse(node.SelectSingleNode("./th").InnerText);
                    listWithFreights.Add(freight);


                }

            }

            
       



        }

        private  void  Login()
        {

        }
    }
}



//foreach (var item in htmlNodes)
//{
//    Console.WriteLine(item.NodeType);
//}
//  var result2 = htmlDoc.DocumentNode.SelectSingleNode("//form").Attributes["action"]?.Value;
//var result2=htmlDoc.DocumentNode.SelectSingleNode"//form");
//Console.WriteLine(result2);
//foreach (var item in result2)
//{
//    Console.WriteLine(item.InnerText);
//}
