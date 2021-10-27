using APIComplexEntityFramework.Data.Repositories;
using APIComplexEntityFramework.ModelDTO;
using APIComplexEntityFramework.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace APIComplexEntityFramework.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
        {
            return ConvertCollection(await _userRepository.GetAllUsersAsync());
        }


        public async Task<UserDTO> GetUserByIdAsync(int id)
        {
            if (id.GetType() == Type.GetType("System.Int32"))
                return _mapper.Map<UserDTO>(await _userRepository.GetUserByIdAsync(id));

            return null;
        }

        public async Task<bool> DeleteUserAsync(UserDTO user)
        {
            return await _userRepository.DeleteUserAsync(_mapper.Map<User>(user));
        }

        public async Task<bool> CreateUserAsync(UserDTO user)
        {
            return await _userRepository.CreateUserAsync(_mapper.Map<User>(user));
        }

        public async Task<bool> UpdateUserAsync(UserDTO user)
        {
            return await _userRepository.UpdateUserAsync(_mapper.Map<User>(user));
        }

        private List<UserDTO> ConvertCollection(IEnumerable<User> collectionToConvert)
        {
            List<UserDTO> collectionToReturn = new();

            foreach (var item in collectionToConvert)
            {
                collectionToReturn.Add(_mapper.Map<UserDTO>(item));
            }

            return collectionToReturn;
        }


    }
}
