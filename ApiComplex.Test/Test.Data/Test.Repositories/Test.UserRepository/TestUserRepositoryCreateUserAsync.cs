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
    public class TestUserRepositoryCreateUserAsync
    {
        private readonly ApiContext _context;

        [Fact]
        public void TestUserRepositoryCreteUserAsyncReturnsSomething()
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
        }
    }
}
