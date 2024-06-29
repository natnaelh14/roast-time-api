using RoastTime.API.Models.Domain;

namespace RoastTime.API.Repositories;

public interface IRestaurantRepository
{
    Task<List<Restaurant>> GetAllAsync();
    //
    Task<Restaurant?> GetByIdAsync(Guid id);

    Task<Restaurant> CreateAsync(Restaurant restaurant);

    Task<Restaurant?> UpdateAsync(Guid id, Restaurant restaurant);
    //
    Task<Restaurant?> DeleteAsync(Guid id);
}
