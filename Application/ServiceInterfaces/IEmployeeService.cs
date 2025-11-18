using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceInterfaces
{
    public interface IEmployeeService
    {
        Task<string> CreateEmployeeAsync(Employee employee);

        Task<Employee?> GetEmployeeByIdAsync(int id);

        Task<List<Employee>> GetAllEmployeesAsync();

        Task<string> UpdateEmployeeAsync(Employee existingEmployee, Employee updatedEmployee);

        Task<string> DeletedEmpoyeeAsync(Employee employee);
    }
}
