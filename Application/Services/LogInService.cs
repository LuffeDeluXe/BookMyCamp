using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Exceptions;
using Application.Messages;
using Application.ServiceInterfaces;

namespace Application.Services
{
    public class LogInService : ILogInService
    {
        private readonly ILogInService _logInService;

        public LogInService(ILogInService logInService)
        {
            _logInService = logInService;
        }

        //public async Task<string> CreateLogInAsync(LogIn logIn)
        //{
        //    int result;

        //    string message;
        //    result = await _logInService.CreateLogInAsync(logIn);

        //    if (result == 0)
        //    {
        //        throw new CreateEntityException<LogIn>();
        //    }

        //    return SuccessMessage.Created<LogIn>();
        //}


        //public async Task<LogIn?> GetLogInByIdAsync(int id)
        //{
        //    return await _logInService.GetLogInByIdAsync(id);
        //}


        //public async Task<string> UpdateLogInAsync(LogIn existinLogIn, LogIn updatedLogIn)
        //{
        //    int result;

        //    string message;
        //    result = await _logInService.UpdateLogInAsync(existingLogIn);

        //    if (result == 0)
        //    {
        //        throw new UpdateEntityException<LogIn>();
        //    }

        //    return SuccessMessage.Updated<LogIn>();
        //}

        //public async Task<string> DeleteLogInAsync(LogIn logIn)
        //{
        //    int result;

        //    string message;
        //    result = await _logInService.DeleteLogInAsync(logIn);

        //    if (result == 0)
        //    {
        //        throw new DeleteEntityException<LogIn>();
        //    }

        //    return SuccessMessage.Deleted<LogIn>();
        //}
    }
}
