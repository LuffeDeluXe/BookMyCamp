using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using Domain.Entities.Models;

namespace Application.Mappers
{
    public static class UserMapper
    {
        public static UserLoginDTO ToLoginDTO(User user)
        {
            return new UserLoginDTO
            {
                GuestId = user.GuestId,
                Name = user.Name,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Country = user.Country,
                IsUser = user.IsUser
            };
        }
    }
}