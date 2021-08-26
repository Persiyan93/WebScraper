using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper.Data.Models
{
    public class Town
    {
        public Town()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        public string Name { get; set; }

        public string PostCode { get; set; }

        public string CountryId { get; set; }

        public Country Country { get; set; }

    }
}
