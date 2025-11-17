using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;
using Application.ServiceInterfaces;
using Domain.Entities.Models;

namespace Application.Services
{
    public class GuestService : IGuestService
    {
        private readonly IUserRepository _userRepository;

        public GuestService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<string> CreateUserAsync(User user)
        {
            int result;
            string message;
            result = await _userRepository.CreateUserAsync(user);

            if (result == 0)
            {
                message = "fejl";
            }
            else 
            {
                message = "success";
            }
            return message;
        }

        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetUserByIdAsync(id);
        }

        public async Task UpdateUserAsync(User existingUser, User updatedUser)
        {
           await _userRepository.UpdateUserAsync(existingUser);

        }

        public async Task DeleteUserAsync(User user)
        {
           await _userRepository.DeleteUserAsync(user);
        }
    }

}
