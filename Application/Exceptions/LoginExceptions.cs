using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class IncorrectLoginException : Exception
    {
        public IncorrectLoginException()
            : base("Password or email incorrect") { }
    }
}