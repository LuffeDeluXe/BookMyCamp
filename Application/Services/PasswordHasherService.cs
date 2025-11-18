using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Application.ServiceInterfaces;
using BCrypt.Net;
using Bcrypt = BCrypt.Net.BCrypt;

namespace Application.Services
{
    public class PasswordHasherService : IPasswordHasherService
    {
        public string HashPassword(string password)
        {
            string hashedPassword;
            hashedPassword = Bcrypt.EnhancedHashPassword(password);
            return hashedPassword;
        }
    }
}
