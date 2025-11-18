using Application.Exceptions;
using Application.Messages;
using Application.RepositoryInterfaces;
using Application.ServiceInterfaces;
using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ResourceService : IResourceService
    {
        private readonly IResourceRepository _resourceRepository;

        public ResourceService(IResourceRepository resourceRepository)
        {
            _resourceRepository = resourceRepository;
        }

        public async Task<string> CreateResourceAsync(Resource resource)
        {
            int result;

            string message;
            result = await _resourceRepository.CreateResourceAsync(resource);

            if (result == 0)
            {
                throw new CreateEntityException<Resource>();
            }

            return SuccessMessage.Created<Resource>();
        }


        public async Task<Resource?> GetResourceByIdAsync (int id)
        {
            return await _resourceRepository.GetResourceByIdAsync(id);
        }


        public async Task<string> UpdateResourceAsync(Resource existingResource, Resource updatedResource)
        {
            int result;

            string message;
            result = await _resourceRepository.UpdateResourceAsync(existingResource);

            if (result == 0)
            {
                throw new UpdateEntityException<Resource>();
            }

            return SuccessMessage.Updated<Resource>();
        }

        public async Task<string> DeleteResourceAsync(Resource resource)
        {
            int result;

            string message;
            result = await _resourceRepository.DeleteResourceAsync(resource);

            if (result == 0)
            {
                throw new DeleteEntityException<Resource>();
            }

            return SuccessMessage.Deleted<Resource>();
        }

        
    }
}
