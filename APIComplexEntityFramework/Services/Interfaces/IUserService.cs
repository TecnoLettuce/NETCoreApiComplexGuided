using APIComplexEntityFramework.ModelDTO;
using APIComplexEntityFramework.ModelDTO.Eraser;
using APIComplexEntityFramework.ModelDTO.Writter;
using APIComplexEntityFramework.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Services
{
    public interface IUserService
    {
        Task<bool> CreateUserAsync(UserWritterDTO user);
        Task<bool> DeleteUserAsync(UserEraserDTO user);
        Task<IEnumerable<UserReaderDTO>> GetAllUsersAsync();
        Task<UserReaderDTO> GetUserByIdAsync(int id);
        Task<bool> UpdateUserAsync(UserWritterDTO user);
    }
}