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
    public class TestUserRepositoryGetAllUsersAsync
    {
        private readonly ApiContext _context;

        [Fact]
        public void TestUserRepositoryGetAllUserAsyncReturnsSomething()
        {

            APIComplexEntityFramework.Data.Repositories.UserRepository userRepository = new APIComplexEntityFramework.Data.Repositories.UserRepository(_context);

            Task task = userRepository.GetAllUsersAsync().ContinueWith(
                innserTask =>
                {
                    IEnumerable<User> result = innserTask.Result;
                    Assert.True(result.Count() > 0);
                    Assert.IsType<User>(result.First());
                    Assert.IsType<string>(result.First().Password);
                    Assert.IsType<string>(result.First().Username);
                    Assert.IsType<Int32>(result.First().UserId);
                }
                );
        }
    }
}
