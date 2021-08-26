using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper.Data.Models
{
    public class Company
    {
        public Company()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Users = new HashSet<User>();
            this.Freights = new HashSet<Freight>();
        }
        public string Id { get; set; }

        public ICollection<User> Users { get; set; }

        public ICollection<Freight> Freights { get; set; }
    }
}
