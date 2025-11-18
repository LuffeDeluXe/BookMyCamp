using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;
using Domain.Entities.Models;

namespace Infrastructure.Repositories
{
    public class AddOnRepository : IAddOnRepository
    {
        private readonly BookMyCampDbContext _dbContext;

        public AddOnRepository(BookMyCampDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAddOnAsync (AddOn addOn)
        {
            await _dbContext.AddOns.AddAsync (addOn);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<AddOn?> GetAddOnByIdAsync (int id)
        {
             return await _dbContext.AddOns.FindAsync(id);
        }

        public async Task<int> UpdateAddOnAsync (AddOn addOn)
        {
             _dbContext.AddOns.Update(addOn);
            int result;

            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAddOnAsync (AddOn addOn)
        {
            _dbContext.AddOns.Remove(addOn);
            await _dbContext.SaveChangesAsync();
        }
    }
}
