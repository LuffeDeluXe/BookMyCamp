using Application.RepositoryInterfaces;
using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly BookMyCampDbContext _dbContext;

        public LanguageRepository(BookMyCampDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateLanguageAsync(Language language)
        {
            int result;

            await _dbContext.AddAsync(language);

            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task<Language?> GetLanguageByIdAsync(int id)
        {
            return await _dbContext.Languages.FindAsync(id);
        }

        public async Task<int> UpdateLanguageAsync(Language language)
        {
            int result;

            _dbContext.Update(language);

            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteLanguageAsync(Language language)
        {
            int result;

            _dbContext.Languages.Remove(language);

            return result = await _dbContext.SaveChangesAsync();
        }
    }
}
