using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly BookMyCampDbContext _dbContext;

        public BookingRepository(BookMyCampDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateBookingAsync (Booking booking)
        {
            await _dbContext.Bookings.AddAsync (booking);
            int result;

            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task<Booking?> GetBookingByIdAsync (int id)
        {
            return await _dbContext.Bookings.FindAsync(id);
        }

        public async Task<int> UpdateBookingAsync (Booking booking)
        {
             _dbContext.Bookings.Update (booking);

            int result;

            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteBookingAsync (Booking booking)
        {
            _dbContext.Bookings.Remove (booking);
            int result;

            return result = await _dbContext.SaveChangesAsync();
        }
    }
}
