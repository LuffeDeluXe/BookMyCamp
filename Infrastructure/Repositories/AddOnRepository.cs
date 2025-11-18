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
    public class AddOnRepository : IAddOnRepository
    {
        private readonly BookMyCampDbContext _dbContext;

        public AddOnRepository(BookMyCampDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateAddOnAsync (AddOn addOn)
        {
            int result;

            await _dbContext.AddOns.AddAsync (addOn);

            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task<AddOn?> GetAddOnByIdAsync (int id)
        {
             return await _dbContext.AddOns.FindAsync(id);
        }

        public async Task<List<AddOn>> GetAllAddOnsAsync()
        {
            return await _dbContext.AddOns.ToListAsync();
        }

        public async Task<int> UpdateAddOnAsync (AddOn addOn)
        {
            int result;

            _dbContext.AddOns.Update(addOn);
    

            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAddOnAsync (AddOn addOn)
        {
            int result;
            _dbContext.AddOns.Remove(addOn);

            return result = await _dbContext.SaveChangesAsync();
        }
    }
}
