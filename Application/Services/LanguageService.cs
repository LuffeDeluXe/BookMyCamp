using Application.Exceptions;
using Application.Messages;
using Application.RepositoryInterfaces;
using Application.ServiceInterfaces;
using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly ILanguageRepository _languageRepository;

        public LanguageService(ILanguageRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }

        public async Task<string> CreateLanguageAsync(Language language)
        {
            int result;

            string message;
            result = await _languageRepository.CreateLanguageAsync(language);

            if (result == 0)
            {
                throw new CreateEntityException<Language>();
            }

            return SuccessMessage.Created<Language>();
        }

        public async Task<Language?> GetLanguageByIdAsync(int id)
        {
            return await _languageRepository.GetLanguageByIdAsync(id);
        }

        public async Task<string> UpdateLanguageAsync(Language existingLanguage, Language updatedLanguage)
        {
            int result;

            string message;
            result = await _languageRepository.UpdateLanguageAsync(existingLanguage);

            if (result == 0)
            {
                throw new UpdateEntityException<Language>(); 
            }

            return SuccessMessage.Updated<Language>();
        }

        public async Task<string> DeleteLanguageAsync(Language language)
        {
            int result;

            string message;
            result = await _languageRepository.DeleteLanguageAsync(language);

            if (result == 0)
            {
                throw new DeleteEntityException<Language>();
            }

            return SuccessMessage.Deleted<Language>();
        }
    }
}
