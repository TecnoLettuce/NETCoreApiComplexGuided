using APIComplexEntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.Data.Test.Repositories.Test.UserRepository
{
    public class TestUserRepositoryCtor
    {
        private readonly ApiContext _context;

        [Fact]
        public void TestUserRepositoryCtorReturnsSomething() {

            APIComplexEntityFramework.Data.Repositories.UserRepository userRepository = new APIComplexEntityFramework.Data.Repositories.UserRepository(_context);

            Assert.NotNull(userRepository);
        }
    }
}
