using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;
using Application.ServiceInterfaces;
using Domain.Entities.Models;

namespace Application.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task CreateBookingAsync(Booking booking)
        {
            await _bookingRepository.CreateBookingAsync(booking);
        }

        public async Task<Booking?> GetBookingByIdAsync (int id)
        {
            return await _bookingRepository.GetBookingByIdAsync(id);
        }

        public async Task UpdateBookingById (Booking existingBooking, Booking updatedBooking)
        {
            await _bookingRepository.UpdateBookingAsync(existingBooking);
        }

        public async Task DeleteBookingAsync (Booking booking)
        {
            _bookingRepository?.DeleteBookingAsync(booking);
        }
}

}
