using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ServiceInterfaces;

namespace Application.Services
{
    public class PasswordHasherService : IPasswordHasherService
    {
        private readonly IPasswordHasherService _passwordHasherService;

        public PasswordHasherService(IPasswordHasherService passwordHasherService)
        {
            _passwordHasherService = passwordHasherService;
        }
    }
}
