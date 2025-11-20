using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.APIInterfaces;
using Application.DTOs;
using Application.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookMyCamp.Server.APIControllers
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
        public async Task<IActionResult> Login(LoginDTO dto)
        {
            var user = await _logInService.LoginCheck(dto.Email, dto.Password);

            if (user == null)
            {
                return Unauthorized();
            }

            var token = _jwtService.GenerateUserJWTToken(user);

            return Ok(new
            {
                token = token,
                user = user
            });
        }
    }
}