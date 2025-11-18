using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ServiceInterfaces;
using Domain.Entities.Models;
using Bcrypt = BCrypt.Net.BCrypt;
using Application.Exceptions;
using Application.Messages;

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

        public async Task<string> LoginCheck(int userId, string incomingEmail, string incomingPassword)
        {
            User? user = await _guestService.GetUserByIdAsync(userId);

            if (user != null)
            {
                bool isCorrectPassword = VerifyPassword(incomingPassword, user.HashedPassword);

                if (user.Email == incomingEmail && isCorrectPassword == true)
                {
                    return 
                }
            }
            else
            {
                throw new LoginException
            }
        }

        public bool VerifyPassword(string incomingPassword, string storedPassword)
        {
            bool correctPassword = Bcrypt.EnhancedVerify(incomingPassword, storedPassword);

            return correctPassword;
        }
    }
}
