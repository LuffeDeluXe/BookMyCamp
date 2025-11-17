using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Models;

namespace Application.RepositoryInterfaces
{
    public interface IBookingRepository
    {
        Task CreateBookingAsync(Booking booking);

        Task<Booking?> GetBookingByIdAsync(int id);

        Task UpdateBookingAsync(Booking booking);

        Task DeleteBookingAsync(Booking booking);

    }
}
