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
    public class TestLikeRepositoryGetLikeByIdAsync
    {
        private readonly ApiContext _context;

        [Fact]
        public void TestGetLikeByIdAsyncResturnsSomething()
        {
            APIComplexEntityFramework.Data.Repositories.LikeRepository likeRepository = new APIComplexEntityFramework.Data.Repositories.LikeRepository(_context);

            Task task = likeRepository.GetLikeByIdAsync(0).ContinueWith(
                innserTask =>
                {
                    Like result = innserTask.Result;
                    Assert.IsType<Like>(result);
                    Assert.IsType<Int32>(result.LikeId);
                    Assert.IsType<Int32>(result.PostId);
                    Assert.IsType<Int32>(result.UserId);
                    Assert.IsType<User>(result.User);
                    Assert.IsType<Post>(result.Post);
                }
                );

        }
    }
}
