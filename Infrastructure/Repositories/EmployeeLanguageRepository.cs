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
    public class EmployeeLanguageRepository : IEmployeeLanguageRepository
    {
        private readonly BookMyCampDbContext _dbContext;

        public EmployeeLanguageRepository(BookMyCampDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateEmployeeLanguageAsync(EmployeeLanguage employeeLanguage)
        {
            await _dbContext.AddAsync(employeeLanguage);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<EmployeeLanguage?> GetEmployeeLanguageByIdAsync(int id)
        {
            return await _dbContext.EmployeeLanguages.FindAsync(id);
        }

        public async Task UpdateEmployeeLanguageAsync(EmployeeLanguage employeeLanguage)
        {
            _dbContext.EmployeeLanguages.Update(employeeLanguage);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteEmployeeLanguageAsync(EmployeeLanguage employeeLanguage)
        {
            _dbContext.Update(employeeLanguage);
            await _dbContext.SaveChangesAsync();
        }

    }
}
