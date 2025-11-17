using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly ILanguageRepository _languageRepository;

        public LanguageRepository(ILanguageRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }
    }
}
