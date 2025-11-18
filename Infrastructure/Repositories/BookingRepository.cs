using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

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
            int result;

            await _dbContext.Bookings.AddAsync (booking);
           

            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task<Booking?> GetBookingByIdAsync (int id)
        {
            return await _dbContext.Bookings.FindAsync(id);
        }

        public async Task<List<Booking>> GetAllBookingsAsync()
        {
            return await _dbContext.Bookings.ToListAsync();
        }


        public async Task<int> UpdateBookingAsync (Booking booking)
        {
            int result;

            _dbContext.Bookings.Update (booking);

            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteBookingAsync (Booking booking)
        {
            int result;

            _dbContext.Bookings.Remove (booking);
  
            return result = await _dbContext.SaveChangesAsync();
        }
    }
}
