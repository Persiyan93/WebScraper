using System;

namespace WebScraper.Data.Models
{
    public class Freight
    {

        public string Id { get; set; }

        public DateTime  DateOfLoading { get; set; }

        public DateTime PostedOn { get; set; }

        public DateTime DateOfRemoval { get; set; }

        public int Views { get; set; }
        
        public string UserId { get; set; }

        public string User { get; set; }

        public string LoadingTownId { get; set; }

        public Town LoadingTown { get; set; }

        public string UnloadingTownId { get; set; }

        public Town UnloadingTown { get; set; }

        public double Weight { get; set; }

        public string AdditionalInfo { get; set; }








    }
}