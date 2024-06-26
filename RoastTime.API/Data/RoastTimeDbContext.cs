using Microsoft.EntityFrameworkCore;

namespace RoastTime.API.Data;

public class RoastTimeDbContext:DbContext
{
    public RoastTimeDbContext(DbContextOptions<RoastTimeDbContext> dbContextOptions): base(dbContextOptions)
    {
    }
    public DbSet<Restaurant> Restaturants { get; set; }

    
}