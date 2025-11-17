using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeRepository(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
    }
}
