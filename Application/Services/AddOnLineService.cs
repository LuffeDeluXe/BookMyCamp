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
    public class AddOnLineService : IAddOnLineService
    {
        private readonly IAddOnLineRepository _addOnLineRepository;

        public AddOnLineService(IAddOnLineRepository addOnLineRepository)
        {
            _addOnLineRepository = addOnLineRepository;
        }

        public async Task<string> CreateAddOnLineAsync (AddOnLine addOnLine)
        {
            int result;

            result = await _addOnLineRepository.CreateAddOnLineAsync(addOnLine);

            if (result == 0)
            {
                throw new CreateEntityException<AddOnLine>();
            }

            return SuccessMessage.Created<AddOnLine>();
        }

        public async Task<AddOnLine?> GetAddOnLineByIdAsync (int id)
        {
            return await _addOnLineRepository.GetAddOnLineById(id);

        }

        public async Task<List<AddOnLine>> GetAllAddOnLinesAsync ()
        {
            return await _addOnLineRepository.GetAllAddOnLinesAsync();
        }

        public async Task<string> UpdateAddOnLineAsync (AddOnLine existingAddOnLine, AddOnLine updatedAddOnLine)
        {
            int result;

            result = await _addOnLineRepository.UpdateAddOnLineAsync(existingAddOnLine);

            if (result == 0) 
            { 
                throw new UpdateEntityException<AddOnLine>();
            }

            return SuccessMessage.Updated<AddOnLine>();

        }

        public async Task<string> DeleteAddOnLineAsync (AddOnLine addOnLine)
        {
            int result;

            result = await _addOnLineRepository.DeleteAddOnLineAsync(addOnLine);

            if (result == 0)
            {
                throw new DeleteEntityException<AddOnLine>();
            }

            return SuccessMessage.Deleted<AddOnLine>();
        }
    }
}
