using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BookMyCampDbContext _dbContext;

        public UserRepository(BookMyCampDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateUserAsync(User user)
        {
            int result;
            await _dbContext.Users.AddAsync(user);
            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _dbContext.Users.FindAsync(id);
        }

        public async Task<int> UpdateUserAsync(User user)
        {
            int result;
            _dbContext.Users.Update(user);
            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteUserAsync(User user)
        {
            int result;
            _dbContext.Users.Remove(user);
            return result = await _dbContext.SaveChangesAsync();
        }


    }
}
