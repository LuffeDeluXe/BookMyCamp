using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceInterfaces
{
    public interface IFacilityService
    {
        Task<string> CreateFacilityAsync(Facility facility);

        Task<Facility?> GetFacilityByIdAsync(int id);

        Task<List<Facility>> GetAllFacilitiesAsync();

        Task<string> DeleteFacilityAsync(Facility facility);
    }
}
