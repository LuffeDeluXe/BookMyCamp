using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public async Task CreateAddOnAsync(AddOn addOn)
        {
            await _addOnRepository.CreateAddOnAsync(addOn);

        }

        public async Task<AddOn?> GetAddOnById(int id)
        {
            return await _addOnRepository.GetAddOnByIdAsync(id);
        }

        public async Task UpdateAddOAsync(AddOn existingAddOn, AddOn updatedAddOn)
        {
            await _addOnRepository.UpdateAddOnAsync(existingAddOn);
        }

        public async Task DeleteAddOnAsync (AddOn addOn)
        {
            await _addOnRepository.DeleteAddOnAsync(addOn);
        }
    }
}
