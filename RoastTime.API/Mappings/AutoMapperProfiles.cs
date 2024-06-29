using AutoMapper;
using RoastTime.API.Models.Domain;
using RoastTime.API.Models.DTO;

namespace RoastTime.API.Mappings;

public class AutoMapperProfiles: Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Restaurant, RestaurantDto>().ReverseMap();

        CreateMap<AddRestaurantRequestDto, Restaurant>().ReverseMap();
        
        CreateMap<UpdateRestaurantRequestDto, Restaurant>().ReverseMap();
    }
}

