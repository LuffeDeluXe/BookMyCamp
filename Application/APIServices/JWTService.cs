using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Application.APIInterfaces;
using Application.DTOs;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;

namespace Application.APIServices
{
    public class JWTService : IJWTService
    {
        private readonly IConfiguration _configuration;

        public JWTService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateEmployeeJWTToken(EmployeeLoginDTO employeeDTO)
        {
            var key = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, employeeDTO.EmployeeId.ToString()),
                new Claim(ClaimTypes.Name, employeeDTO.Name),
                new Claim(ClaimTypes.Email, employeeDTO.Email),
                new Claim(ClaimTypes.MobilePhone, employeeDTO.PhoneNumber.ToString()),
                new Claim(ClaimTypes.Role, employeeDTO.IsUser ? "User" : "User")
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