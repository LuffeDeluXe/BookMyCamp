using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceInterfaces
{
    public interface IResourceService
    {
        Task<string> CreateResourceAsync(Resource resource);

        Task<Resource?> GetResourceByIdAsync(int id);

        Task<string> UpdateResourceAsync(Resource existingResource, Resource updatedResource);

        Task<string> DeleteResourceAsync(Resource resource);
    }
}
