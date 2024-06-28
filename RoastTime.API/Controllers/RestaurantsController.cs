using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RoastTime.API.CustomActionFilters;
using RoastTime.API.Models.Domain;
using RoastTime.API.Models.DTO;
using RoastTime.API.Repositories;

namespace RoastTime.API.Controllers;

[Route("[controller]")]
[ApiController]
public class RestaurantsController: ControllerBase
{
    private readonly IMapper mapper;
    private readonly IRestaurantRepository restaurantRepository;

    public RestaurantsController(IMapper mapper, IRestaurantRepository restaurantRepository)
    {
        this.mapper = mapper;
        this.restaurantRepository = restaurantRepository;
    }
    
    [HttpPost]
    [ValidateModel]
    public async Task<IActionResult> Create([FromBody] AddRestaurantRequestDto addRestaurantRequestDto)
    {
        // Map DTO to Domain Model
        var restaurantDomainModel = mapper.Map<Restaurant>(addRestaurantRequestDto);

        await restaurantRepository.CreateAsync(restaurantDomainModel);

        // Map Domain model to DTO
        return Ok(mapper.Map<RestaurantDto>(restaurantDomainModel));
    }
}