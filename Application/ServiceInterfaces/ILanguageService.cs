using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceInterfaces
{
    public interface ILanguageService
    {
        Task<string> CreateLanguageAsync(Language language);

        Task<Language?> GetLanguageByIdAsync(int id);

        Task<string> UpdateLanguageAsync(Language existingLanguage, Language updatedLanguage);

        Task<string> DeleteLanguageAsync(Language language);
    }
}
