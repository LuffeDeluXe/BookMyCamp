using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public class Booking
    {
        [Key]

        public int BookingId { get; set; }

        [ForeignKey ("GuestId")]

        public int GuestId { get; set; }

        public virtual Guest Guest { get; set; } = null!;


        [ForeignKey ("ResourceId")]

        public int ResourceId { get; set; }

        public virtual Resource Resource{ get; set; }

        public int GuestAmount { get; set; }

        [Required]
        public DateOnly StartDate { get; set; }

        [Required]
        public DateOnly EndDate { get; set; }
    }
}
