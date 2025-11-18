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
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task<string> CreateBookingAsync(Booking booking)
        {
            int result;

            result = await _bookingRepository.CreateBookingAsync(booking);

            if (result == 0)
            {
                throw new CreateEntityException<Booking>();
            }

            return SuccessMessage.Created<Booking>();
        }

        public async Task<Booking?> GetBookingByIdAsync (int id)
        {
            return await _bookingRepository.GetBookingByIdAsync(id);
        }

        public async Task<List<Booking>> GetAllBookingsAsync ()
        {
            return await _bookingRepository.GetAllBookingsAsync();
        }

        public async Task<string> UpdateBookingById (Booking existingBooking, Booking updatedBooking)
        {
            int result;
            result = await _bookingRepository.UpdateBookingAsync(existingBooking);

            if (result == 0)
            {
                throw new UpdateEntityException<Booking>();
            }

            return SuccessMessage.Updated<Booking>();
        }

        public async Task<string> DeleteBookingAsync (Booking booking)
        {
            int result;
            result = await _bookingRepository.DeleteBookingAsync(booking);

            if (result == 0)
            {
                throw new DeleteEntityException<Booking>();
            }

            return SuccessMessage.Deleted<Booking>();
        }
}

}
