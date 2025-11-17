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
        Task CreateAddOnAsync(AddOn addOn);

        Task<AddOn?> GetAddOnById(int id);

        Task UpdateAddOAsync(AddOn existingAddOn, AddOn updatedAddOn);

        Task DeleteAddOnAsync(AddOn addOn);
    }
}
