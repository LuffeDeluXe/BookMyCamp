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

        public async Task CreateEmployeeLanguageAsync(EmployeeLanguage employeeLanguage)
        {
            await _employeeLanguageRepository.CreateEmployeeLanguageAsync(employeeLanguage);
        }

        public async Task<EmployeeLanguage?> GetEmployeeLanguageByIdAsync(int id)
        {
            return await _employeeLanguageRepository.GetEmployeeLanguageByIdAsync(id);
        }

        public async Task UpdateEmployeeLanguageAsync(EmployeeLanguage existingEmployeeLanguage, EmployeeLanguage updatedEmployeeLanguage)
        {
            await _employeeLanguageRepository.UpdateEmployeeLanguageAsync(existingEmployeeLanguage);
        }
    }
}


//Hello sunshine the earth says "Hellooo"