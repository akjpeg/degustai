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
        public DbSet<User> Users { get; set; }
    }
}