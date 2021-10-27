using APIComplexEntityFramework.ModelDTO;
using APIComplexEntityFramework.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Services
{
    public interface IUserService
    {
        Task<bool> CreateUserAsync(UserDTO user);
        Task<bool> DeleteUserAsync(UserDTO user);
        Task<IEnumerable<UserDTO>> GetAllUsersAsync();
        Task<UserDTO> GetUserByIdAsync(int id);
        Task<bool> UpdateUserAsync(UserDTO user);
    }
}