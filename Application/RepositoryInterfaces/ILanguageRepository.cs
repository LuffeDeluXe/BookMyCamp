using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RepositoryInterfaces
{
    public interface ILanguageRepository
    {
        Task<int> CreateLanguageAsync(Language language);

        Task<Language?> GetLanguageByIdAsync(int id);

        Task<int> UpdateLanguageAsync(Language language);

        Task<int> DeleteLanguageAsync(Language language);
    }
}
