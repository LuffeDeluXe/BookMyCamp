using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CreateAddOnDTO
    {
        public string Product { get; set; }
        public int Prize { get; set; }
    }

    public class UpdateAddOnDTO
    {
        public string Product { get; set; }
        public int Prize { get; set; }
    }

    public class AddOnDetailsDTO
    {
        public int AddOnId { get; set; }
        public string Product { get; set; }
        public int Prize { get; set; }
    }

    public class AddOnListDTO
    {
        public int AddOnId { get; set; }
        public string Product { get; set; }
        public int Prize { get; set; }
    }
}
