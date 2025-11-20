using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CreateBookingDTO
    {
        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }
        public int GuestAmount { get; set; }
    }

    public class UpdateBookingDTO
    {
        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }

        public int ResourceId { get; set; }
        public int GuestAmount { get; set; }


    }

    public class BookingDetailsDTO
    {
        public int BookingId { get; set; }

        public int ResourceId {  set; get; }
        public DateOnly StartDate { get; set; }

        public TimeSpan Duration { get; set; }

        public DateOnly EndDate { get; set; }
        public int GuestAmount { get; set; }

    }

    public class BookingListDTO
    {
        public int BookingId { get; set; }

        public int ResourceId { get; set; }
        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }

        public int GuestAmount { get; set; }

        public int GuestId { get; set; }
    }
}
