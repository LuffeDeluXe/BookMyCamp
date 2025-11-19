using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;

namespace Application.APIInterfaces
{
    public interface IJWTService
    {
        string GenerateUserJWTToken(UserLoginDTO userDTO);
    }
}