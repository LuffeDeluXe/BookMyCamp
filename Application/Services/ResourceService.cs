using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ServiceInterfaces;

namespace Application.Services
{
    public class ResourceService : IResourceService
    {
        private readonly IResourceService _resourceService;

        public ResourceService(IResourceService resourceService)
        {
            _resourceService = resourceService;
        }
    }
}
