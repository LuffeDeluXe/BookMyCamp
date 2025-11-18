using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Exceptions;
using Application.Messages;
using Application.RepositoryInterfaces;
using Application.ServiceInterfaces;
using Domain.Entities.Models;

namespace Application.Services
{
    public class AddOnService : IAddOnService
    {
        private readonly IAddOnRepository _addOnRepository;

        public AddOnService(IAddOnRepository addOnRepository)
        {
            _addOnRepository = addOnRepository;
        }

        public async Task<string> CreateAddOnAsync(AddOn addOn)
        {
            int result;
            result = await _addOnRepository.CreateAddOnAsync(addOn);

            if (result == 0)
            {
                throw new CreateEntityException<AddOn>();
            }

            return SuccessMessage.Created<AddOn>();

        }

        public async Task<AddOn?> GetAddOnById(int id)
        {

            return await _addOnRepository.GetAddOnByIdAsync(id);
        }

        public async Task<List<AddOn>> GetAllAddOnsAsync ()
        {
            return await _addOnRepository.GetAllAddOnsAsync();
        }

        public async Task<string> UpdateAddOAsync(AddOn existingAddOn, AddOn updatedAddOn)
        {
            int result;
            result = await _addOnRepository.UpdateAddOnAsync(existingAddOn);

            if (result == 0)
            {
                throw new UpdateEntityException<AddOn>();
            }
            return SuccessMessage.Updated<AddOn>();
        }

        public async Task<string> DeleteAddOnAsync (AddOn addOn)
        {
            int result;
            result = await _addOnRepository.DeleteAddOnAsync(addOn);

            if (result == 0)
            {
                throw new DeleteEntityException<AddOn>();
            }

            return SuccessMessage.Deleted<AddOn>();
        }
    }
}
