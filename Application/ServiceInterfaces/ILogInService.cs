using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceInterfaces
{
    public interface ILogInService
    {
        Task<string> LoginCheck(string incomingEmail, string incomingPassword);

        bool VerifyPassword(string passwordInput, string password);
    }
}
