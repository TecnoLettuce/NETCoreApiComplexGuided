using APIComplexEntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.Data.Test.Repositories.Test.PostRepository
{
    public class TestPostRepositoryCtor
    {
        private readonly ApiContext _context;

        [Fact]
        public void TestPostRepositoryCtorReturnsSomething() {

            APIComplexEntityFramework.Data.Repositories.PostRepository postRepository = new APIComplexEntityFramework.Data.Repositories.PostRepository(_context);

            Assert.NotNull(postRepository);
        }
    }
}
