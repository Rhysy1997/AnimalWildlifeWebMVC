using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using AnimalWildlife.Data.Animals;


namespace AnimalWildlife.Data.Repository
{
    public class AnimalsDBContext : DbContext
    {
        public AnimalsDBContext()
        {
        }

        public AnimalsDBContext(DbContextOptions<AnimalsDBContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AnimalsDB;Trusted_Connection=True;");
        }

        //testing purposes method - remove after testing
        public void Initialise()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

    }
}
