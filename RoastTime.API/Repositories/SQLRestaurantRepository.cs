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
    
    public async Task<Restaurant?> UpdateAsync(Guid id, Restaurant restaurant)
    {
        var existingRestaurant = await dbContext.Restaturants.FirstOrDefaultAsync(x => x.Id == id);

        if (existingRestaurant == null)
        {
            return null;
        }

        existingRestaurant.Name = restaurant.Name;
        existingRestaurant.Address = restaurant.Address;
        existingRestaurant.Latitude = restaurant.Latitude;
        existingRestaurant.Longitude = restaurant.Longitude;
        existingRestaurant.Category = restaurant.Category;

        await dbContext.SaveChangesAsync();
        return existingRestaurant;
    }
    
    public async Task<Restaurant?> DeleteAsync(Guid id)
    {
        var existingRestaurant = await dbContext.Restaturants.FirstOrDefaultAsync(x => x.Id == id);

        if (existingRestaurant == null)
        {
            return null;
        }

        dbContext.Restaturants.Remove(existingRestaurant);
        await dbContext.SaveChangesAsync();
        return existingRestaurant;
    }
}