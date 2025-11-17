using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ServiceInterfaces;

namespace Application.Services
{
    public class LogInService : ILogInService
    {
        private readonly ILogInService _logInService;

        public LogInService(ILogInService logInService)
        {
            _logInService = logInService;
        }
    }
}
