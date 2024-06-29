using System.ComponentModel.DataAnnotations;

namespace RoastTime.API.Models.DTO;

public class AddRestaurantRequestDto
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Required]
    [MaxLength(100)]
    public string Address { get; set; }
    
    [Required]
    public double Latitude { get; set; }
    
    [Required]
    public double Longitude { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Category { get; set; }
}

