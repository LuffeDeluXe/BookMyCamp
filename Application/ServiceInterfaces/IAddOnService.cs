using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceInterfaces
{
    public interface IAddOnService
    {
        Task<string> CreateAddOnAsync(AddOn addOn);

        Task<AddOn?> GetAddOnById(int id);

        Task<string> UpdateAddOAsync(AddOn existingAddOn, AddOn updatedAddOn);

        Task<string> DeleteAddOnAsync(AddOn addOn);
    }
}
