using System;

namespace WebScraper.Data.Models
{
    public class User
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string Name { get; set; }


        public string CompanyId { get; set; }

        public Company Company { get; set; }
    }
}