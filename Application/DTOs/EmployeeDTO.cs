using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class EmployeeDTO
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }
    }
}

