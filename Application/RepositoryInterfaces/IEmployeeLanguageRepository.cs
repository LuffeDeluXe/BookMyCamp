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
        Task CreateEmployeeLanguageAsync(EmployeeLanguage employeeLanguage);

        Task<EmployeeLanguage?> GetEmployeeLanguageByIdAsync(int id);

        Task UpdateEmployeeLanguageAsync(EmployeeLanguage employeeLanguage);

        Task DeleteEmployeeLanguageAsync(EmployeeLanguage employeeLanguage);
    }
}
