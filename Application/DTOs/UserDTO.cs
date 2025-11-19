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
    public class CreateUpdateUserDTO
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public int LanguageId { get; set; }

        public string LandCode { get; set; }

        public int PhoneNumber { get; set; }

        public int PostalCode { get; set; }

        public string City { get; set; }

        public string Adress {  get; set; }

        public string Country { get; set; }


    }

    public class UserListDto
    {
        public int GuestId { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public int LanguageId { get; set; }

        public int PhoneNumber { get; set; }

        public string Country { get; set; }

    }

    public class UserLoginDTO
    {
        public int GuestId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string LandCode { get; set; }
    }
}

