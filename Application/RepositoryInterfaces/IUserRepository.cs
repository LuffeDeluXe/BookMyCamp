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
        Task CreateUserAsync(User user);

        Task<User?> GetUserByIdAsync(int id);

        Task UpdateUserAsync(User user);

        Task DeleteUserAsync(User user);
    }
}
