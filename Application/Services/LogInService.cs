using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Exceptions;
using Application.Messages;
using Application.ServiceInterfaces;
using Domain.Entities.Models;
using Bcrypt = BCrypt.Net.BCrypt;
using Application.Messages;
using Application.Exceptions;
using Application.DTOs;
using Application.Mappers;

namespace Application.Services
{
    public class LogInService : ILogInService
    {
        private readonly IEmployeeService _employeeService;
        private readonly IPasswordHasherService _passwordHasherService;

        public LogInService(IEmployeeService employeeService, IPasswordHasherService passwordHasherService)
        {
            _employeeService = employeeService;
            _passwordHasherService = passwordHasherService;
        }

        public async Task<UserLoginDTO> LoginCheck(string incomingEmail, string incomingPassword)
        {
            Employee? employee = await _employeeService.GetEmployeeByEmailAsync(incomingEmail);
            

            if (employee != null)
            {
                bool isCorrectPassword = VerifyPassword(incomingPassword, employee.HashedPassword);

                if (employee.Email == incomingEmail && isCorrectPassword == true)
                {
                    return UserMapper.ToLoginDTO(employee);
                }
                else
                {
                    throw new IncorrectLoginException();
                }
            }
            else
            {
                throw new IncorrectLoginException();
            }
        }

        public bool VerifyPassword(string incomingPassword, string storedPassword)
        {
            bool correctPassword = Bcrypt.EnhancedVerify(incomingPassword, storedPassword);

            return correctPassword;
        }
    }
}
