using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper.Data.Models
{
    public class Country
    {
        public Country()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Towns = new HashSet<Town>();
        }
        public string Id { get; set; }

        public string Code { get; set; }

         public string Name { get; set; }

        public ICollection<Town> Towns { get; set; }
    }
}
