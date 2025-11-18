using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RepositoryInterfaces
{
    public interface IEmployeeRepository
    {
        Task<int> CreateEmployeeAsync(Employee employee);

        Task<Employee?> GetEmployeeByIdAsync(int id);

        Task<List<Employee>> GetAllEmployeesAsync();

        Task<int> UpdateEmployeeAsync(Employee employee);

        Task<int> DeleteEmployeeAsync(Employee employee);
    }
}
