using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RepositoryInterfaces
{
    public interface IAddOnLineRepository
    {
        Task CreateAddOnLineAsync(AddOnLine addOnLine);

        Task<AddOnLine?> GetAddOnLineById(int id);

        Task UpdateAddOnLineAsync(AddOnLine addOnLine);

        Task DeleteAddOnLineAsync(AddOnLine addOnLine);
    }
}
