using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;
using Application.ServiceInterfaces;
using Domain.Entities.Models;

namespace Application.Services
{
    public class EmployeeLanguageService : IEmployeeLanguageService
    {
        private readonly IEmployeeLanguageRepository _employeeLanguageRepository;

        public EmployeeLanguageService(IEmployeeLanguageRepository employeeLanguageRepository)
        {
            _employeeLanguageRepository = employeeLanguageRepository;
        }
    }
}
