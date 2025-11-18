using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Exceptions;
using Application.Messages;
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
                throw new CreateEntityException<User>();
            }

            return SuccessMessage.Created<User>();
        }

        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetUserByIdAsync(id);
        }

        public async Task<string> UpdateUserAsync(User existingUser, User updatedUser)
        {
            int result;

            string message;
            result = await _userRepository.UpdateUserAsync(existingUser);

            if (result == 0)
            {
                throw new UpdateEntityException<User>(); 
            }

            return SuccessMessage.Updated<User>();
        }

        public async Task<string> DeleteUserAsync(User user)
        {
            int result;

            string message;
            result = await _userRepository.DeleteUserAsync(user);

            if (result == 0)
            {
                throw new DeleteEntityException<User>(); 
            }

            return SuccessMessage.Deleted<User>();
        }
    }

}
