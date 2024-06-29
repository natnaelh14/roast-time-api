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
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        // Get Data From Database - Domain models
        var regionsDomain = await restaurantRepository.GetAllAsync();

        // Return DTOs
        return Ok(mapper.Map<List<RestaurantDto>>(regionsDomain));
    }
    
    [HttpGet]
    [Route("{id:Guid}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        // Get Region Domain Model From Database
        var regionDomain = await restaurantRepository.GetByIdAsync(id);

        if (regionDomain == null)
        {
            return NotFound();
        }
        // Return DTO back to client
        return Ok(mapper.Map<RestaurantDto>(regionDomain));
    }
}