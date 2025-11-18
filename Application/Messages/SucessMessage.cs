using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Messages
{
    public static class SuccessMessage
    {
        public static string Created<TEntity>()
            => $"{typeof(TEntity).Name} was created successfully.";

        public static string Updated<TEntity>()
            => $"{typeof(TEntity).Name} was updated successfully.";

        public static string Deleted<TEntity>()
            => $"{typeof(TEntity).Name} was deleted successfully.";
    }
}
