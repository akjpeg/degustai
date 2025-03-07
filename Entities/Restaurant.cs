using DegustAi.Enums;

namespace DegustAi.Entities;

public class Restaurant
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string? Email { get; set; }
    public string? Website { get; set; }
    public string CuisineType { get; set; }
    public string? OpeningHours { get; set; }
    public PriceRange? PriceRange { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}