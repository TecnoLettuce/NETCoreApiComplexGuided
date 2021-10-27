using APIComplexEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Data.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly ApiContext _context;

        public UserRepository(ApiContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _context.User.ToArrayAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.User.FirstOrDefaultAsync(f => f.UserId == id);
        }

        public async Task<bool> DeleteUserAsync(User user)
        {
            bool result = _context.User.Remove(user) != null;
            if (result)
                await _context.SaveChangesAsync();

            return result;

        }

        public async Task<bool> CreateUserAsync(User user)
        {
            bool result = await _context.AddAsync(user) != null;
            if (result)
                await _context.SaveChangesAsync();

            return result;
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            var userExtracted = _context.User.FirstOrDefault(u => u.UserId == user.UserId);

            if (userExtracted != null)
            {
                userExtracted.Username = user.Username;
                userExtracted.Password = user.Password;

                // _context.User.Update(userExtracted); --> Funciona tanto si le ponemos esto como si no.
                await _context.SaveChangesAsync();
                return true;
            }
            return false;

        }




    }
}
