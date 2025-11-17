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
        Task CreateBookingAsync(Booking booking);

        Task<Booking?> GetBookingByIdAsync(int id);

        Task UpdateBookingById(Booking existingBooking, Booking updatedBooking);

        Task DeleteBookingAsync(Booking booking);

        }
}
