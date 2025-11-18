using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CreateBookingDTO
    {
        public int CustomerId { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public int GuestCount { get; set; }
    }

    public class UpdateBookingDTO
    {
        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }

        public int ResourceId { get; set; }
        public int GuestCount { get; set; }

    }

    public class BookingDetailsDTO
    {
        public int BookingId { get; set; }
        public DateOnly StartDate { get; set; }

        public TimeSpan Duration { get; set; }

        public DateOnly EndDate { get; set; }
        public int GuestCount { get; set; }

        public List<AddOnListLineDTO> AddOns { get; set; } = new();
    }

    public class BookingListDTO
    {
        public int BookingId { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int GuestCount { get; set; }

        public int GuestId { get; set; }
    }
}
