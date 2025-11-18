using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Messages
{
    public class LoginMessages
    {
        public static string LoginSuccess()
            => "Login successful";

        public static string ConfirmationSent()
            => "Confirmation email successfully sent";

        public static string PasswordChanged()
            => "Password successfully changed";
    }
}