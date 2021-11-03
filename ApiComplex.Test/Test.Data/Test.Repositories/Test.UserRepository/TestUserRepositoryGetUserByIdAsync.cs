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
    public class TestUserRepositoryGetUserByIdAsync
    {
        private readonly ApiContext _context;

        [Fact]
        public void TestUserRepositoryGetUserByIdAsyncReturnsSomething()
        {

            APIComplexEntityFramework.Data.Repositories.UserRepository userRepository = new APIComplexEntityFramework.Data.Repositories.UserRepository(_context);

            Task task = userRepository.GetUserByIdAsync(0).ContinueWith(
                innserTask =>
                {
                    User result = innserTask.Result;
                    Assert.IsType<User>(result);
                    Assert.IsType<string>(result.Password);
                    Assert.IsType<string>(result.Username);
                    Assert.IsType<Int32>(result.UserId);
                }
                );
        }
    }
}
