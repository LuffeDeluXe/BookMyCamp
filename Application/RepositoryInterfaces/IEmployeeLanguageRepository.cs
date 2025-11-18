using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RepositoryInterfaces
{
    public interface IEmployeeLanguageRepository
    {
        Task<int> CreateEmployeeLanguageAsync(EmployeeLanguage employeeLanguage);

        Task<EmployeeLanguage?> GetEmployeeLanguageByIdAsync(int id);

        Task<List<Employee>> GetAllEmployeeLanguagesAsync();

        Task<int> UpdateEmployeeLanguageAsync(EmployeeLanguage employeeLanguage);

        Task<int> DeleteEmployeeLanguageAsync(EmployeeLanguage employeeLanguage);
    }
}
