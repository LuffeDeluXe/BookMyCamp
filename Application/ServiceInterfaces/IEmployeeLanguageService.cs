using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceInterfaces
{
    public interface IEmployeeLanguageService
    {
        Task<string> CreateEmployeeLanguageAsync(EmployeeLanguage employeeLanguage);

        Task<EmployeeLanguage?> GetEmployeeLanguageByIdAsync(int id);

        Task<string> UpdateEmployeeLanguageAsync(EmployeeLanguage existingEmployeeLanguage, EmployeeLanguage updatedEmployeeLanguage);

        Task<string> DeleteEmployeeLanguageAsync(EmployeeLanguage employeeLanguage);

    }
}
