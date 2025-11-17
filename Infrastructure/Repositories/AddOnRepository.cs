using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class AddOnRepository : IAddOnRepository
    {
        private readonly IAddOnRepository _addOnRepository;

        public AddOnRepository(IAddOnRepository addOnRepository)
        {
            _addOnRepository = addOnRepository;
        }
    }
}
