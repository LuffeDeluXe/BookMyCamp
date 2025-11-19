using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ServiceInterfaces;
using Domain.Entities.Models;
using Bcrypt = BCrypt.Net.BCrypt;
using Application.Messages;
using Application.Exceptions;

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

        public async Task<string> LoginCheck(string incomingEmail, string incomingPassword)
        {
            User? user = await _guestService.GetUserByEmailAsync(incomingEmail);

            if (user != null)
            {
                bool isCorrectPassword = VerifyPassword(incomingPassword, user.HashedPassword);

                if (user.Email == incomingEmail && isCorrectPassword == true)
                {
                    return LoginMessages.LoginSuccess();
                }
                else
                {
                    throw new IncorrectPasswordException();
                }
            }
            else
            {
                throw new NoUserFoundException();
            }
        }

        public bool VerifyPassword(string incomingPassword, string storedPassword)
        {
            bool correctPassword = Bcrypt.EnhancedVerify(incomingPassword, storedPassword);

            return correctPassword;
        }
    }
}
