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
    public class AddOnLineRepository : IAddOnLineRepository
    {
        private readonly BookMyCampDbContext _dbContext;

        public AddOnLineRepository(BookMyCampDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateAddOnLineAsync (AddOnLine addOnLine)
        {
            await _dbContext.AddAsync(addOnLine);
            int result;

            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task<AddOnLine?> GetAddOnLineById (int id)
        {
            return await _dbContext.AddOnsLine.FindAsync(id);

       
        }

        public async Task<int> UpdateAddOnLineAsync (AddOnLine addOnLine)
        {
             _dbContext.Update(addOnLine);
            int result;

            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAddOnLineAsync (AddOnLine addOnLine)
        {
            _dbContext.AddOnsLine.Remove(addOnLine);

            int result;

            return result = await _dbContext.SaveChangesAsync();
        }
    }
}

