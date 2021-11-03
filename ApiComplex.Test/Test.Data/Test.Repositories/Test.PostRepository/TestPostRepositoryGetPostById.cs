using APIComplexEntityFramework;
using APIComplexEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.Data.Test.Repositories.Test.PostRepository
{
    public class TestPostRepositoryGetPostById
    {
        private readonly ApiContext _context;

        [Fact]
        public void TestPostRepositoryGetPostByIdAsyncReturnsSomething()
        {

            APIComplexEntityFramework.Data.Repositories.PostRepository postRepository = new APIComplexEntityFramework.Data.Repositories.PostRepository(_context);

            Task task = postRepository.GetPostByIdAsync(0).ContinueWith(
                innserTask =>
                {
                    Post result = innserTask.Result;
                    Assert.IsType<Int32>(result.PostId);
                    Assert.IsType<Int32>(result.UserId);
                    Assert.IsType<Int32>(result.Rate);
                    Assert.IsType<Int32>(result.Rate);
                    Assert.IsType<string>(result.ImxPost);
                    Assert.IsType<User>(result.User);
                    Assert.IsType<Post>(result);
                }
                );
        }
    }
}
