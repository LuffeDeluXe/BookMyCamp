using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ServiceInterfaces;

namespace Application.Services
{
    public class EmployeeLanguageService : IEmployeeLanguageService
    {
        private readonly IEmployeeLanguageService _employeeLanguageService;

        public EmployeeLanguageService(IEmployeeLanguageService employeeLanguageService)
        {
            _employeeLanguageService = employeeLanguageService;
        }
    }
}
