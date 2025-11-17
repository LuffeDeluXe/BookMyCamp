using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class ResourceRepository : IResourceRepository
    {
        private readonly IResourceRepository _resourceRepository;

        public ResourceRepository(IResourceRepository resourceRepository)
        {
            _resourceRepository = resourceRepository;
        }
    }
}
