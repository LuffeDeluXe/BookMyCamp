using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceInterfaces
{
    public interface IAddOnLineService
    {
        Task<string> CreateAddOnLineAsync(AddOnLine addOnLine);

        Task<AddOnLine?> GetAddOnLineByIdAsync(int id);

        Task<List<AddOnLine>> GetAllAddOnLinesAsync();

        Task<string> UpdateAddOnLineAsync(AddOnLine existingAddOnLine, AddOnLine updatedAddOnLine);

        Task<string> DeleteAddOnLineAsync(AddOnLine addOnLine);

    }
}
