using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RepositoryInterfaces
{
    public interface IAddOnRepository
    {
        Task CreateAddOnAsync(AddOn addOn);

        Task<AddOn?> GetAddOnByIdAsync(int id);

        Task UpdateAddOnAsync(AddOn addOn);

        Task DeleteAddOnAsync(AddOn addOn);
    }
}
