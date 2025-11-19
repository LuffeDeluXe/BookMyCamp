using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.APIInterfaces;
using Application.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace GUI.APIControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILogInService _logInService;
        private readonly IJWTService _jwtService;

        public LoginController(ILogInService logInService, IJWTService jwtService)
        {
            _logInService = logInService;
            _jwtService = jwtService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(SignInModel dto)
        {
            
        }
    }
}