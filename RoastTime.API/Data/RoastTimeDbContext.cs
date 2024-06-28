using Microsoft.EntityFrameworkCore;
using RoastTime.API.Models.Domain; 

namespace RoastTime.API.Data;

public class RoastTimeDbContext:DbContext
{
    public RoastTimeDbContext(DbContextOptions<RoastTimeDbContext> dbContextOptions): base(dbContextOptions)
    {
    }
    public DbSet<Restaurant> Restaturants { get; set; }
    
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Restaurants
            var restaurants = new List<Restaurant>
            {
                new Restaurant
                {
                    Id = Guid.Parse("f7248fc3-2585-4efb-8d1d-1c555f4087f6"),
                    Name = "Black Lion",
                    Address = "8240 Fenton St, Silver Spring, MD 20910",
                    Latitude = 38.9977,
                    Longitude = -77.0306,
                    Category = "Coffee Shop"
                },
                new Restaurant
                {
                    Id = Guid.Parse("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"),
                    Name = "Kaldis Coffee",
                    Address = "918 Silver Spring Ave, Silver Spring, MD 20910",
                    Latitude = 38.9977,
                    Longitude = -77.0306,
                    Category = "Coffee Shop"                },
            };

            modelBuilder.Entity<Restaurant>().HasData(restaurants);
        }
}

