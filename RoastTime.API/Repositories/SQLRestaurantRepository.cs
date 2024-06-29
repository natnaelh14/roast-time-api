using Microsoft.EntityFrameworkCore;
using RoastTime.API.Models.Domain;
using RoastTime.API.Data;

namespace RoastTime.API.Repositories;

public class SQLRestaurantRepository: IRestaurantRepository
{
    private readonly RoastTimeDbContext dbContext;

    public SQLRestaurantRepository(RoastTimeDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<Restaurant> CreateAsync(Restaurant restaurant)
    {
        await dbContext.Restaturants.AddAsync(restaurant);
        await dbContext.SaveChangesAsync();
        return restaurant;
    }
    
    public async Task<List<Restaurant>> GetAllAsync()
    {
        return await dbContext.Restaturants.ToListAsync();
    }
    
    public async Task<Restaurant?> GetByIdAsync(Guid id)
    {
        return await dbContext.Restaturants.FirstOrDefaultAsync(x => x.Id == id);
    }
}