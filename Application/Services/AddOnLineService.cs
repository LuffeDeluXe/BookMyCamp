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
    public class AddOnLineService : IAddOnLineService
    {
        private readonly IAddOnLineRepository _addOnLineRepository;

        public AddOnLineService(IAddOnLineRepository addOnLineRepository)
        {
            _addOnLineRepository = addOnLineRepository;
        }

        public async Task CreateAddOnLineAsync (AddOnLine addOnLine)
        {
            await _addOnLineRepository.CreateAddOnLineAsync(addOnLine);

        }

        public async Task<AddOnLine?> GetAddOnLineByIdAsync (int id)
        {
            return await _addOnLineRepository.GetAddOnLineById(id);

        }

        public async Task UpdateAddOnLineAsync (AddOnLine existingAddOnLine, AddOnLine updatedAddOnLine)
        {
            await _addOnLineRepository.UpdateAddOnLineAsync(existingAddOnLine);

        }

        public async Task DeleteAddOnLineAsync (AddOnLine addOnLine)
        {
            await _addOnLineRepository.DeleteAddOnLineAsync(addOnLine);
        }
    }
}
