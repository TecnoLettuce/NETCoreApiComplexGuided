using APIComplexEntityFramework;
using APIComplexEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.Data.Test.Repositories.Test.UserRepository
{
    public class TestUserRepositoryUpdateUserAsync
    {

        private readonly ApiContext _context;

        [Fact]
        public void TestUserRepositoryUpdateUserAsyncReturnsSomething()
        {

            APIComplexEntityFramework.Data.Repositories.UserRepository userRepository = new APIComplexEntityFramework.Data.Repositories.UserRepository(_context);

            User userToInsert = new User();
            userToInsert.Username = "sample";
            userToInsert.Password = "sample";

            Task task = userRepository.CreateUserAsync(userToInsert).ContinueWith(
                innserTask =>
                {
                    bool result = innserTask.Result;
                    Assert.True(result);
                }
                );

            userToInsert.Username = "Updated";
            userToInsert.Password = "Updated";

            Task task2 = userRepository.UpdateUserAsync(userToInsert).ContinueWith(
                innserTask =>
                {
                    bool result = innserTask.Result;
                    Assert.True(result);
                }
                );

            Task task3 = userRepository.GetUserByIdAsync(userToInsert.UserId).ContinueWith(
                innserTask =>
                {
                    User result = innserTask.Result;
                    Assert.True(result.UserId == userToInsert.UserId);
                    Assert.True(result.Username == userToInsert.Username);
                    Assert.True(result.Password == userToInsert.Password);
                }
                );


        }
    }
}
