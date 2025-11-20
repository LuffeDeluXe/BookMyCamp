using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RepositoryInterfaces
{
    public interface IUserRepository
    {
        Task<int> CreateUserAsync(User user);

        Task<User?> GetUserByEmailAsync(string email);

        Task<User?> GetUserByIdAsync(int id);

        Task<int> UpdateUserAsync(User user);

        Task<int> DeleteUserAsync(User user);
    }
}
