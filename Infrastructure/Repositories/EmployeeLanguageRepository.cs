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

        public async Task<int> CreateEmployeeLanguageAsync(EmployeeLanguage employeeLanguage)
        {
            int result;
            await _dbContext.AddAsync(employeeLanguage);
            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task<EmployeeLanguage?> GetEmployeeLanguageByIdAsync(int id)
        {
            return await _dbContext.EmployeeLanguages.FindAsync(id);
        }

        public async Task<List<EmployeeLanguage>> GetAllEmployeeLanguagesAsync()
        {
            return await _dbContext.EmployeeLanguages.ToListAsync();
        }


        public async Task<int> UpdateEmployeeLanguageAsync(EmployeeLanguage employeeLanguage)
        {
            int result;
            _dbContext.EmployeeLanguages.Update(employeeLanguage);
            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteEmployeeLanguageAsync(EmployeeLanguage employeeLanguage)
        {
            int result;
            _dbContext.Update(employeeLanguage);
            return result = await _dbContext.SaveChangesAsync();
        }

    }
}
