using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Application.APIInterfaces;
using Application.DTOs;
using Microsoft.IdentityModel.Tokens;

namespace Infrastructure.APIs.APIServices
{
    public class JWTService : IJWTService
    {
        private readonly IConfiguration _configuration;

        public JWTService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateUserJWTToken(UserLoginDTO userDTO)
        {
            var key = Encoding.UTF8.GetBytes(_configuration["AppSettings:Token"]);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userDTO.GuestId.ToString()),
                new Claim(ClaimTypes.Name, userDTO.Name),
                new Claim(ClaimTypes.Email, userDTO.Email),
                new Claim(ClaimTypes.MobilePhone, userDTO.PhoneNumber.ToString()),
                new Claim(ClaimTypes.Country, userDTO.Country),
                new Claim(ClaimTypes.Role, userDTO.IsUser ? "User" : "User")
            };

            var credentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddHours(24),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}