using Application.RepositoryInterfaces;
using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ResourceRepository : IResourceRepository
    {
        private readonly BookMyCampDbContext _dbContext;

        public ResourceRepository(BookMyCampDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateResourceAsync(Resource resource)
        {
            int result;

            await _dbContext.AddAsync(resource);

            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task<Resource?> GetResourceByIdAsync(int id)
        {
            return await _dbContext.Resources.FindAsync(id);
        }

        public async Task<int> UpdateResourceAsync(Resource resource)
        {
            int result;

            _dbContext.Update(resource);

            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteResourceAsync(Resource resource)
        {
            int result;

            _dbContext.Resources.Remove(resource);

            return result = await _dbContext.SaveChangesAsync();
        }
    }
}
