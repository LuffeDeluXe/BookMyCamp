using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly BookMyCampDbContext _dbContext;

        public LanguageRepository(BookMyCampDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
