using APIComplexEntityFramework.Data.Repositories;
using APIComplexEntityFramework.ModelDTO;
using APIComplexEntityFramework.ModelDTO.Eraser;
using APIComplexEntityFramework.ModelDTO.Writter;
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

        public async Task<IEnumerable<UserReaderDTO>> GetAllUsersAsync()
        {
            return ConvertCollection(await _userRepository.GetAllUsersAsync());
        }

        public async Task<UserReaderDTO> GetUserByIdAsync(int id)
        {
            if (id.GetType() == Type.GetType("System.Int32"))
                return _mapper.Map<UserReaderDTO>(await _userRepository.GetUserByIdAsync(id));

            return null;
        }

        public async Task<bool> DeleteUserAsync(UserEraserDTO user)
        {
            return await _userRepository.DeleteUserAsync(_mapper.Map<User>(user));
        }

        public async Task<bool> CreateUserAsync(UserWritterDTO user)
        {
            return await _userRepository.CreateUserAsync(_mapper.Map<User>(user));
        }

        public async Task<bool> UpdateUserAsync(UserWritterDTO user)
        {
            return await _userRepository.UpdateUserAsync(_mapper.Map<User>(user));
        }

        private List<UserReaderDTO> ConvertCollection(IEnumerable<User> collectionToConvert)
        {
            List<UserReaderDTO> collectionToReturn = new();

            foreach (var item in collectionToConvert)
            {
                collectionToReturn.Add(_mapper.Map<UserReaderDTO>(item));
            }

            return collectionToReturn;
        }


    }
}
