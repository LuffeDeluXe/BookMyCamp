using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceInterfaces
{
    public interface IBookingService
    {
        Task<string> CreateBookingAsync(Booking booking);

        Task<Booking?> GetBookingByIdAsync(int id);

        Task<string> UpdateBookingById(Booking existingBooking, Booking updatedBooking);

        Task<string> DeleteBookingAsync(Booking booking);

        }
}
