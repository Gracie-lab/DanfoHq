using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using danfologistics.Models;
using Microsoft.EntityFrameworkCore;

namespace danfologistics.DbContexts
{
    public class DataContext : DbContext
    {

        public DataContext(){

            }
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql ("A FALLBACK CONNECTION STRING");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Bus> Buses { get; set; }

        public List<Bus> getBuses () => Buses.ToList();

        private void LoadDefaultBuses()
        {
            Buses.Add(new Bus { id = 100L, name = "Toyota", color = "white" });
            Buses.Add(new Bus { id = 200L, name = "Marcopolo", color = "Arthur" });
        }   
    }
}
