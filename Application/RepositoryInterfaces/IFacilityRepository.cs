using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RepositoryInterfaces
{
    public interface IFacilityRepository
    {
        Task<int> CreateFacilityAsync(Facility facility);

        Task<Facility?> GetFacilityByIdAsyc(int id);

        Task<List<Facility>> GetAllFacilitiesAsync();

        Task<int> UpdateFacilityAsync(Facility facility);

        Task<int> DeleteFacilityAsync(Facility facility);
        }
}
