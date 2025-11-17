using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingRepository(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }
    }
}
