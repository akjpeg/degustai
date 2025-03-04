
using ASPNETCoreBackend.Repositories.Implementations;
using ASPNETCoreBackend.Repositories.Interfaces;
using ASPNETCoreBackend.Services.Interfaces;
using DegustAi.Data;
using DegustAi.Entities;
using Microsoft.AspNetCore.Http.HttpResults;

namespace ASPNETCoreBackend.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public void AddUser(int id, string name, string email, string password)
        {
            User newUser = new User(id, name, email, password);
            
            _repository.AddUser(newUser);
   
        }

        public User? FindUserByName(string name)
        {
            User user = _repository.FindUserByName(name);
            
            if(user!=null) 
            {
                return user;
            }

            else
            {
                throw new KeyNotFoundException("User não encontrado"); 
            }

        }

        public User? GetById(int id)
        {
            User user = _repository.GetById(id);
            
            if(user!=null) 
            {
                return user;
            }

            else
            {
                throw new KeyNotFoundException("User não encontrado"); 
            }

        }
        

        public void RemoveUserByName(string name)
        {
            User user = _repository.FindUserByName(name);
            if(user==null) 
            {
                throw new KeyNotFoundException("User não encontrado, nenhuma ação será realizada"); 
            }
            else
            {
                _repository.RemoveUser(user);
            }

        }


        public void RemoveUserById(int id)
        {
            User user = _repository.GetById(id);
            if(user==null) 
            {
                throw new KeyNotFoundException("User não encontrado, nenhuma ação será realizada"); 
            }
            else
            {
                _repository.RemoveUser(user);
            }

        }

        public void UpdateUser(int id, string? name, string? email, string? password)
        {
            User user = this.GetById(id);
            
            user.Name = name ?? user.Name;
            user.Email = email ?? user.Email;
            user.Password = password ?? user.Password;
            
            _repository.UpdateUser(user);
      
        }
    }
}