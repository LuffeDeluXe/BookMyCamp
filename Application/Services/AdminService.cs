using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.ServiceInterfaces;

namespace Application.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminService _adminService;
        public AdminService(IAdminService adminService)
        {
            _adminService = adminService;
        }
    }
}