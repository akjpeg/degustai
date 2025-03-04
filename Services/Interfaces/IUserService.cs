using DegustAi.Entities;

namespace ASPNETCoreBackend.Services.Interfaces
{
    public interface IUserService
    {
        User? GetById(int id);
        User? FindUserByName(string name);
        void AddUser(int id, string name, string email, string password);
        void RemoveUserByName(string name);

        void RemoveUserById(int id);
        void UpdateUser(int id, string? name, string? email, string? password);
    }
}