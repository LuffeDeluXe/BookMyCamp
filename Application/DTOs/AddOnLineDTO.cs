using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CreateAddOnLineDTO
    {
        public int AddOnId { get; set; }
        public int BookingId { get; set; }
        public int Amount { get; set; }
    }

    public class UpdateAddOnLineDTO
    {
        public int Amount { get; set; }

    }

    public class AddOnDetailsLineDTO
    {
        public int AddOnLineId { get; set; }
        public int AddOnId { get; set; }
        public string AddOnProduct { get; set; }
        public int IndividualPrice { get; set; }
        public int Amount { get; set; }
        public int PriceSum { get; set; }
    }

    public class AddOnListLineDTO
    {
        public int AddOnLineId { get; set; }
        public string AddOnProduct { get; set; }
        public int Amount { get; set; }
        public int IndividualPrice { get; set; }
        public int PriceSum { get; set; }
    }
}
