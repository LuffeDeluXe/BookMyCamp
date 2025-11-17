using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ServiceInterfaces;

namespace Application.Services
{
    public class GuestService : IGuestService
    {
        private readonly IGuestService _guestService;

        public GuestService(IGuestService guestService)
        {
            _guestService = guestService;
        }
    }
}
