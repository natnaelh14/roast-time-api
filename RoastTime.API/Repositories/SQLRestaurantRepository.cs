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
}