using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class EmployeeLoginRepository
    {
        private readonly BookMyCampDbContext _dbContext;

        public EmployeeLoginRepository(BookMyCampDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateEmployeeLogin(EmployeeLogin employeeLogin)
        {
            int result;

            result = await _dbContext.EmployeeLogi
        }
    }
}