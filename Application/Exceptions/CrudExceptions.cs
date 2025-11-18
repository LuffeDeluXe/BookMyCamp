using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class CreateEntityException<TEntity> : Exception
    {
        public CreateEntityException()
            : base($"{typeof(TEntity).Name} was not created.") { }
    }

    public class UpdateEntityException<TEntity> : Exception
    {
        public UpdateEntityException()
            : base($"{typeof(TEntity).Name} was not updated.") { }
    }

    public class DeleteEntityException<TEntity> : Exception
    {
        public DeleteEntityException()
            : base($"{typeof(TEntity).Name} was not deleted.") { }
    }
}
