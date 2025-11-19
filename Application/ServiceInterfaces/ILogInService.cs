using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;

namespace Application.ServiceInterfaces
{
    public interface ILogInService
    {
        Task<UserLoginDTO> LoginCheck(string incomingEmail, string incomingPassword);

        bool VerifyPassword(string passwordInput, string password);
    }
}
