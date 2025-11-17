using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class ResourceRepository : IResourceRepository
    {
        private readonly BookMyCampDbContext _dbContext;

        public ResourceRepository(BookMyCampDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
