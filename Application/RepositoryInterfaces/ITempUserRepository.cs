using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RepositoryInterfaces
{
    public interface ITempUserRepository
    {
        Task<int> CreateTempUserAsync(TempUser tempUser);

        Task<TempUser?> GetTempUserByIdAsync(int id);

        Task<int> UpdateTempUserAsync(TempUser tempUser);

        Task<int> DeleteTempUserAsync(TempUser tempUser);
    }
}
