using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class EmployeeLanguageRepository : IEmployeeLanguageRepository
    {
        private readonly IEmployeeLanguageRepository _employeeLanguageRepository;

        public EmployeeLanguageRepository(IEmployeeLanguageRepository employeeLanguageRepository)
        {
            _employeeLanguageRepository = employeeLanguageRepository;
        }
    }
}
