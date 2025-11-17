using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceInterfaces
{
    public interface IGuestService
    {
        Task<string> CreateUserAsync(User user);

        Task<User?> GetUserByIdAsync(int id);

        Task UpdateUserAsync(User existingUser, User updatedUser);

        Task DeleteUserAsync(User user);
    }
}
