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
        Task<int> CreateBookingAsync(Booking booking);

        Task<Booking?> GetBookingByIdAsync(int id);

        Task<int> UpdateBookingAsync(Booking booking);

        Task<int> DeleteBookingAsync(Booking booking);

    }
}
