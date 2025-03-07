using DegustAi.Entities;
using Microsoft.EntityFrameworkCore;

namespace DegustAi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Add DbSet properties for your entities
        public DbSet<User> User { get; set; }
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<Dish> Dish { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Photo> Photo { get; set; }
    }
}