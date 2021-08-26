using Microsoft.EntityFrameworkCore;
using System;
using WebScraper.Data.Models;

namespace WebScraper.Data    
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {

        }


        public DbSet<User> Users { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<Freight> Freights { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Company> Companies { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=SpeditorWebScraper;Integrated Security=True;");
            }
        }

        protected override  void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }
}
