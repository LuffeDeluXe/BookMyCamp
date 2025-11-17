using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class FacilityRepository : IFacilityRepository
    {
        private readonly IFacilityRepository _facilityRepository;

        public FacilityRepository(IFacilityRepository facilityRepository)
        {
            _facilityRepository = facilityRepository;
        }
    }
}
