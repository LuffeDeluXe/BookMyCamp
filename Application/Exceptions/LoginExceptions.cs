using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class NoUserFoundException<TEntity> : Exception
    {
        public NoUserFoundException()
            : base($"{typeof(TEntity).Name} was not created.") { }
    }
}