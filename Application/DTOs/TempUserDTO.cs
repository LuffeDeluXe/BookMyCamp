using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CreateUpdateTempUserDTO
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string LandCode { get; set; }
        public int PhoneNumber { get; set; }

        public int LanguageId { get; set; }
    }

    public class TempUserDTO
    {
        public int GuestId { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string LandCode { get; set; }
        public int PhoneNumber { get; set; }

        public int LanguageId { get; set; }
    }
}


