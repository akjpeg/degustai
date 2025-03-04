
using ASPNETCoreBackend.Repositories.Interfaces;
using DegustAi.Data;
using DegustAi.Entities;

namespace ASPNETCoreBackend.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User? FindUserByName(string name)
        {
            User User = _context.Users.FirstOrDefault(c => c.Name == name );

            return User;
        }

        public User? GetById(int id)
        {
            User User = _context.Users.FirstOrDefault(c => c.Id == id);

            return User;
        }

        public void RemoveUser(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}