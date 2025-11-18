using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class NoUserFoundException : Exception
    {
        public NoUserFoundException()
            : base("Could not find existing user with that email") { }
    }

    public class IncorrectPasswordException : Exception
    {
        public IncorrectPasswordException()
            : base("Password is incorrect") { }
    }
}