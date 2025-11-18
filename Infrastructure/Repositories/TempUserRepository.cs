using Application.RepositoryInterfaces;
using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TempUserRepository : ITempUserRepository
    {
        private readonly BookMyCampDbContext _dbContext;

        public TempUserRepository(BookMyCampDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateTempUserAsync(TempUser tempUser)
        {
            int result;

            await _dbContext.AddAsync(tempUser);

            return result = await _dbContext.SaveChangesAsync();
        }


        public async Task<TempUser?> GetTempUserByIdAsync(int id)
        {
            return await _dbContext.TempUsers.FindAsync(id);
        }


        public async Task<int> UpdateTempUserAsync(TempUser tempUser)
        {
            int result;

            _dbContext.Update(tempUser);

            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteTempUserAsync(TempUser tempUser)
        {
            int result;

            _dbContext.Remove(tempUser);

            return result = await _dbContext.SaveChangesAsync();
        }
    }
}
