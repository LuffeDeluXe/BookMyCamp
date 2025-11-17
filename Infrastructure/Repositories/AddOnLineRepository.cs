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

        public async Task CreateAddOnLineAsync (AddOnLine addOnLine)
        {
            await _dbContext.AddAsync(addOnLine);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<AddOnLine?> GetAddOnLineById (int id)
        {
            return await _dbContext.AddOnsLine.FindAsync(id);

       
        }

        public async Task UpdateAddOnLineAsync (AddOnLine addOnLine)
        {
             _dbContext.Update(addOnLine);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAddOnLineAsync (AddOnLine addOnLine)
        {
            _dbContext.AddOnsLine.Remove(addOnLine);

            await _dbContext.SaveChangesAsync();
        }
    }
}

