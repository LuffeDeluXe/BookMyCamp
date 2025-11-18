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
    public class FacilityService : IFacilityService
    {
        private readonly IFacilityRepository _facilityRepository;

        public FacilityService(IFacilityRepository facilityRepository)
        {
            _facilityRepository = facilityRepository;
        }

        public async Task<string> CreateFacilityAsync (Facility facility)
        {
            int result;

            result = await _facilityRepository.CreateFacilityAsync (facility);

            if (result == 0)
            {
                throw new CreateEntityException<Facility>();
            }

            return SuccessMessage.Created<Facility>();
        }

        public async Task<Facility?> GetFacilityByIdAsync (int id)
        {
            return  await _facilityRepository.GetFacilityByIdAsyc(id);
        }

        public async Task<List<Facility>>GetAllFacilitiesAsync ()
        {
            return await _facilityRepository.GetAllFacilitiesAsync();
        }

        public async Task<string> UpdateFacilityAsync(Facility facility)
        {
            int result;

            result = await _facilityRepository.UpdateFacilityAsync(facility);

            if (result == 0)
            {
                throw new UpdateEntityException<Facility>();
            }

            return SuccessMessage.Updated<Facility>();
        }

        public async Task<string> DeleteFacilityAsync (Facility facility)
        {
            int result;

            result = await _facilityRepository.DeleteFacilityAsync(facility);

            if (result == 0)
            {
                throw new DeleteEntityException<Facility>();
            }

            return SuccessMessage.Deleted<Facility>();
        }

    }
}
