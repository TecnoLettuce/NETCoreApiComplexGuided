using APIComplexEntityFramework;
using APIComplexEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.Data.Test.Repositories.Test.LikeRepository
{
    public class TestLikeRepositoryGetLikeByUserIdAsync
    {

        private readonly ApiContext _context;

        [Fact]
        public void TestGetLikeByUserIdAsyncResturnsSomething()
        {
            APIComplexEntityFramework.Data.Repositories.LikeRepository likeRepository = new APIComplexEntityFramework.Data.Repositories.LikeRepository(_context);

            Task task = likeRepository.GetLikedByUserId(0).ContinueWith(
                innserTask =>
                {
                    IEnumerable<Like> result = innserTask.Result;
                    Assert.IsType<Like>(result.First());
                    Assert.IsType<Int32>(result.First().LikeId);
                    Assert.IsType<Int32>(result.First().PostId);
                    Assert.IsType<Int32>(result.First().UserId);
                    Assert.IsType<User>(result.First().User);
                    Assert.IsType<Post>(result.First().Post);
                }
                );

        }
    }
}
