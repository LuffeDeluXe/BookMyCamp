using Application.DTOs;
using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class BookingMapper
    {
        public static Booking ToEntity(this CreateBookingDTO dto)
            => new Booking { StartDate = dto.StartDate, EndDate = dto.EndDate, GuestAmount = dto.GuestAmount };

        public static Booking ToEntity(this UpdateBookingDTO dto, Booking existing)
        {
            existing.StartDate = dto.StartDate;
            existing.EndDate = dto.EndDate;
            existing.GuestAmount = dto.GuestAmount;
            existing.ResourceId = dto.ResourceId;
            return existing;

        }

        public static BookingListDTO ToListDTO (this Booking entity)
            => new BookingListDTO { BookingId = entity.BookingId, ResourceId = entity.ResourceId, StartDate = entity.StartDate, EndDate = entity.EndDate, GuestAmount = entity.GuestAmount, GuestId = entity.GuestId };

        public static BookingDetailsDTO ToDetailsDTO (this Booking entity)
            => new BookingDetailsDTO { BookingId = entity.BookingId, ResourceId = entity.ResourceId, StartDate = entity.StartDate, EndDate =entity.EndDate, Duration = entity.Duration, GuestAmount = entity.GuestAmount };

    }
}
