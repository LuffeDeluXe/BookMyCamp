using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Exceptions;
using Application.Messages;
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
            result = await _employeeLanguageRepository.CreateEmployeeLanguageAsync(employeeLanguage);

            if (result == 0)
            {
                throw new CreateEntityException<EmployeeLanguage>();
            }

            return SuccessMessage.Created<EmployeeLanguage>();
        }

        public async Task<EmployeeLanguage?> GetEmployeeLanguageByIdAsync(int id)
        {
            return await _employeeLanguageRepository.GetEmployeeLanguageByIdAsync(id);
        }


        public async Task<string> UpdateEmployeeLanguageAsync(EmployeeLanguage existingEmployeeLanguage, EmployeeLanguage updatedEmployeeLanguage)
        {
            int result;

            result = await _employeeLanguageRepository.UpdateEmployeeLanguageAsync(existingEmployeeLanguage);
            if (result == 0)
            {
                throw new UpdateEntityException<EmployeeLanguage>();
            }

            return SuccessMessage.Updated<EmployeeLanguage>();
        }
                

        public async Task<string> DeleteEmployeeLanguageAsync(EmployeeLanguage employeeLanguage)
        {
            int result;
            result = await _employeeLanguageRepository.DeleteEmployeeLanguageAsync(employeeLanguage);

            if (result == 0)
            {
                throw new DeleteEntityException<EmployeeLanguage>();
            }

            return SuccessMessage.Deleted<EmployeeLanguage>();
        }
    }
}

