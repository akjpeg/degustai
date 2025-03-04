using DegustAi.Entities;

namespace ASPNETCoreBackend.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User? GetById(int id);
        User? FindUserByName(string name);
        void AddUser(User user);
        void RemoveUser(User user);
        void UpdateUser(User user);
    }
}