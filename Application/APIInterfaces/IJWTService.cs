using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.APIInterfaces
{
    public interface IJWTService
    {
        string GenerateJWTToken();
    }
}