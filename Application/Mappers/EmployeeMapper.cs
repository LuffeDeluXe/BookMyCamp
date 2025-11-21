using Application.DTOs;
using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class EmployeeMapper
    {
        public static Employee ToEntity (this EmployeeDTO dto)
            => new Employee { Name =  dto.Name, Email = dto.Email, PhoneNumber = dto.PhoneNumber };

        public static Employee ToUpdateEntity (this EmployeeDTO dto, Employee existing)
        {
            existing.Email = dto.Email;
            existing.PhoneNumber = dto.PhoneNumber;
            existing.Name = dto.Name;

            return existing;
        }

        public static EmployeeDTO ToListDetailsDTO(this Employee entity)
            => new EmployeeDTO { PhoneNumber = entity.PhoneNumber, Email = entity.Email, Name = entity.Name };

    }
}


