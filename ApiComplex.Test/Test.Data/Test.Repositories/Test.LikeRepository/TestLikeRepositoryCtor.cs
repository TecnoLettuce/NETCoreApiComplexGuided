using APIComplexEntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIComplexEntityFramework.Data.Repositories;
using Xunit;

namespace ApiComplex.Test.Test.Data.Test.Repositories.Test.LikeRepository
{
    public class TestLikeRepositoryCtor
    {
        private readonly ApiContext _context;

        [Fact]
        public void TestRepositoryCtor()
        {
            APIComplexEntityFramework.Data.Repositories.LikeRepository likeRepository = new APIComplexEntityFramework.Data.Repositories.LikeRepository(_context);

            Assert.NotNull(likeRepository);
            Assert.IsType<APIComplexEntityFramework.Data.Repositories.LikeRepository>(likeRepository);
        }

    }
}
