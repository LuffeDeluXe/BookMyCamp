using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class TempUserRepository : ITempUserRepository
    {
        private readonly BookMyCampDbContext _dbContext;

        public TempUserRepository(BookMyCampDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
