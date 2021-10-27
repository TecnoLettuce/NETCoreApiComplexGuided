using APIComplexEntityFramework.Data.Repositories;
using APIComplexEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace APIComplexEntityFramework.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }


        public async Task<User> GetUserByIdAsync(int id)
        {
            if (id.GetType() == Type.GetType("System.Int32"))
                return await _userRepository.GetUserByIdAsync(id);

            return null;
        }

        public async Task<bool> DeleteUserAsync(User user)
        {
            return await _userRepository.DeleteUserAsync(user);
        }

        public async Task<bool> CreateUserAsync(User user)
        {
            return await _userRepository.CreateUserAsync(user);
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            return await _userRepository.UpdateUserAsync(user);
        }

    }
}
