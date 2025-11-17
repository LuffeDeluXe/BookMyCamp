using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class TempUserRepository : ITempUserRepository
    {
        private readonly ITempUserRepository _tempUserRepository;

        public TempUserRepository(ITempUserRepository tempUserRepository)
        {
            _tempUserRepository = tempUserRepository;
        }
    }
}
