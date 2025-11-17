using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class AddOnLineRepository : IAddOnLineRepository
    {
        private readonly IAddOnLineRepository _addOnLineRepository;

        public AddOnLineRepository(IAddOnLineRepository addOnLineRepository)
        {
            _addOnLineRepository = addOnLineRepository;
        }
    }
}
