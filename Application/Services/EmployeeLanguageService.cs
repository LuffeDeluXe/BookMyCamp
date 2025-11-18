using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;
using Application.ServiceInterfaces;
using Domain.Entities.Models;

namespace Application.Services
{
    public class EmployeeLanguageService : IEmployeeLanguageService
    {
        private readonly IEmployeeLanguageRepository _employeeLanguageRepository;

        public EmployeeLanguageService(IEmployeeLanguageRepository employeeLanguageRepository)
        {
            _employeeLanguageRepository = employeeLanguageRepository;
        }

        public async Task<string> CreateEmployeeLanguageAsync(EmployeeLanguage employeeLanguage)
        {
            int result;
            string message;
            result = await _employeeLanguageRepository.CreateEmployeeLanguageAsync(employeeLanguage);

            if (result == 0) 
            {
                message = "fejl";
            }
            else 
            {
                message = "success";
            }
            return message;
        }

        public async Task<EmployeeLanguage?> GetEmployeeLanguageByIdAsync(int id)
        {
            return await _employeeLanguageRepository.GetEmployeeLanguageByIdAsync(id);
        }

        public async Task<string> UpdateEmployeeLanguageAsync(EmployeeLanguage existingEmployeeLanguage, EmployeeLanguage updatedEmployeeLanguage)
        {
            int result;
            string message;
            result = await _employeeLanguageRepository.UpdateEmployeeLanguageAsync(existingEmployeeLanguage);
            if (result == 0)
            {
                message = "fejl";
            }
            else
            {
                message = "success";
            }
            return message;
        }

        public async Task<string> DeleteEmployeeLanguageAsync(EmployeeLanguage employeeLanguage)
        {
            int result;
            string message;
            result = await _employeeLanguageRepository.DeleteEmployeeLanguageAsync(employeeLanguage);

            if (result == 0)
            {
                message = "fejl";
            }
            else
            {
                message = "success";
            }
            return message;
        }
    }
}


//Hello sunshine the earth says "Hellooo"