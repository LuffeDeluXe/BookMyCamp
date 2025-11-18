using Application.Exceptions;
using Application.Messages;
using Application.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PasswordHasherService : IPasswordHasherService
    {
        private readonly IPasswordHasherService _passwordHasherService;

        public PasswordHasherService(IPasswordHasherService passwordHasherService)
        {
            _passwordHasherService = passwordHasherService;
        }

        //public async Task<string> CreatePasswordHasherAsync(PasswordHasher passwordHasher)
        //{
        //    int result;

        //    string message;
        //    result = await _passwordHasherService.CreatePasswordHasherAsync(passwordHasher);

        //    if (result == 0)
        //    {
        //        throw new CreateEntityException<PasswordHasher>();
        //    }

        //    return SuccessMessage.Created<PasswordHasher>();
        //}


        //public async Task<PasswordHasher?> GetPasswordHasherByIdAsync(int id)
        //{
        //    return await _passwordHasherService.GetPasswordHasherByIdAsync(id);
        //}


        //public async Task<string> UpdatePasswordHasherAsync(PasswordHasher existingPasswordHasher, PasswordHasher updatedPasswordHasher)
        //{
        //    int result;

        //    string message;
        //    result = await _passwordService.UpdatePasswordHasherAsync(existingpasswordHasher);

        //    if (result == 0)
        //    {
        //        throw new UpdateEntityException<PasswordHasher>();
        //    }

        //    return SuccessMessage.Updated<PasswordHasher>();
        //}

        //public async Task<string> DeletePasswordHasherAsync(PasswordHasher passwordHasher)
        //{
        //    int result;

        //    string message;
        //    result = await _passwordHasherService.DeletePasswordHasherAsync(passwordHasher);

        //    if (result == 0)
        //    {
        //        throw new DeleteEntityException<PasswordHasher>();
        //    }

        //    return SuccessMessage.Deleted<PasswordHahser>();
        //}
    }
}
