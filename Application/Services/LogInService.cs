using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Exceptions;
using Application.Messages;
using Application.ServiceInterfaces;
using Domain.Entities.Models;
using Bcrypt = BCrypt.Net.BCrypt;
using Application.Messages;
using Application.Exceptions;
using Application.DTOs;
using Application.Mappers;

namespace Application.Services
{
    public class LogInService : ILogInService
    {
        private readonly IGuestService _guestService;
        private readonly IPasswordHasherService _passwordHasherService;

        public LogInService(GuestService guestService, IPasswordHasherService passwordHasherService)
        {
            _guestService = guestService;
            _passwordHasherService = passwordHasherService;
        }

        public async Task<UserLoginDTO> LoginCheck(string incomingEmail, string incomingPassword)
        {
            User? user = await _guestService.GetUserByEmailAsync(incomingEmail);
            

            if (user != null)
            {
                bool isCorrectPassword = VerifyPassword(incomingPassword, user.HashedPassword);

                if (user.Email == incomingEmail && isCorrectPassword == true)
                {
                    return UserMapper.ToLoginDTO(user);
                }
                else
                {
                    throw new IncorrectLoginException();
                }
            }
            else
            {
                throw new IncorrectLoginException();
            }
        }

        public bool VerifyPassword(string incomingPassword, string storedPassword)
        {
            bool correctPassword = Bcrypt.EnhancedVerify(incomingPassword, storedPassword);

            return correctPassword;
        }
    }
}
