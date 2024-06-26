namespace RoastTime.API.Models.Domain;

public class Restaurant
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public float Latitude { get; set; }
    public float Longitude { get; set; }
    public string Category { get; set; }
    public Guid userId { get; set; }
}