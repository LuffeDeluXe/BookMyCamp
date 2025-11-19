using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Application.APIInterfaces;
using Application.DTOs;

namespace Infrastructure.APIs.APIServices
{
    public class JWTService : IJWTService
    {
        private readonly IConfiguration _configuration;

        public JWTService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateJWTToken(UserLoginDTO userDTO)
        {
            var key = Encoding.UTF8.GetBytes(_configuration["AppSettings:Token"]);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userDTO.GuestId.ToString()),
                new Claim(ClaimTypes.Name, userDTO.Name),
                new Claim(ClaimTypes.Email, userDTO.Email),
                new Claim(ClaimTypes.Phone, )
            };
        }
    }
}