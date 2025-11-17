using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ServiceInterfaces;

namespace Application.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingService _bookingService;

        public BookingService(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
    }
}
