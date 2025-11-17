using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ServiceInterfaces;

namespace Application.Services
{
    public class FacilityService : IFacilityService
    {
        private readonly IFacilityService _facilityService;

        public FacilityService(IFacilityService facilityService)
        {
            _facilityService = facilityService;
        }
    }
}
