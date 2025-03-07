using DegustAi.Enums;

namespace DegustAi.Entities;

public class Dish
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; }
    public DishCategory DishCategory { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public List<Review> Reviews { get; set; } = new List<Review>();
}