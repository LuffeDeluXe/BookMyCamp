using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;
using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly BookMyCampDbContext _dbContext;

        public EmployeeRepository(BookMyCampDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateEmployeeAsync (Employee employee)
        {
            int result;

            await _dbContext.Employees.AddAsync (employee);

            return result = await _dbContext.SaveChangesAsync ();

        }

        public async Task<Employee?> GetEmployeeByIdAsync (int id)
        {
            return await _dbContext.Employees.FindAsync(id);
        }

        public async Task<Employee?> GetEmployeeByEmailAsync(string email)
        {
            return await _dbContext.Employees.FindAsync(email);
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _dbContext.Employees.ToListAsync();
        }


        public async Task<int> UpdateEmployeeAsync (Employee employee)
        {
            int result;

             _dbContext.Employees.Update(employee);

            return result = await _dbContext.SaveChangesAsync ();

        }

        public async Task<int> DeleteEmployeeAsync (Employee employee)
        {
            int result;

             _dbContext.Employees.Remove(employee);

            return result = await _dbContext.SaveChangesAsync();
        }
    }
}
