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
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<string> CreateEmployeeAsync (Employee employee)
        {
            int result;
            result = await _employeeRepository.CreateEmployeeAsync (employee);

            if (result == 0)
            {
                throw new CreateEntityException<Employee>();
            }

            return SuccessMessage.Created<Employee>();
        }

        public async Task<Employee?> GetEmployeeByIdAsync (int id)
        {
            return  await _employeeRepository.GetEmployeeByIdAsync(id);
        }

        public async Task<List<Employee>> GetAllEmployeesAsync ()
        {
            return await _employeeRepository.GetAllEmployeesAsync ();
        }

        public async Task<string> UpdateEmployeeAsync(Employee existingEmployee, Employee updatedEmployee)
        {
            int result;
            result = await _employeeRepository.UpdateEmployeeAsync(existingEmployee);

            if (result == 0)
            {
                throw new UpdateEntityException<Employee>();
            }

            return SuccessMessage.Updated<Employee>();
        }

        public async Task<string> DeletedEmpoyeeAsync (Employee employee)
        {
            int result;

            result = await _employeeRepository.DeleteEmployeeAsync(employee);

            if(result == 0)
            {
                throw new DeleteEntityException<Employee>();
            }

            return SuccessMessage.Deleted<Employee>();
        }
    }
}