using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RepositoryInterfaces
{
    public interface IResourceRepository
    {
        Task<int> CreateResourceAsync(Resource resource);

        Task<Resource?> GetResourceByIdAsync(int id);

        Task<int> UpdateResourceAsync(Resource resource);

        Task<int> DeleteResourceAsync(Resource resource);
    }
}
