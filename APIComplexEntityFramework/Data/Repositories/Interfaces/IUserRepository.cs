using APIComplexEntityFramework.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Data.Repositories
{
    public interface IUserRepository
    {
        Task<bool> CreateUserAsync(User user);
        Task<bool> DeleteUserAsync(User user);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task<bool> UpdateUserAsync(User user);
    }
}