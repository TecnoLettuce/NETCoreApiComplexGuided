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
    public class TestPostRepositoryGetAllPostsAsync
    {
        private readonly ApiContext _context;

        [Fact]
        public void TestPostRepositoryGetAllPostsAsyncReturnsSomething()
        {

            APIComplexEntityFramework.Data.Repositories.PostRepository postRepository = new APIComplexEntityFramework.Data.Repositories.PostRepository(_context);

            Task task = postRepository.GetAllPostsAsync().ContinueWith(
                innserTask =>
                {
                    IEnumerable<Post> result = innserTask.Result;
                    Assert.True(result.Count() > 0);
                    Assert.IsType<Int32>(result.First().PostId);
                    Assert.IsType<Int32>(result.First().UserId);
                    Assert.IsType<Int32>(result.First().Rate);
                    Assert.IsType<Int32>(result.First().Rate);
                    Assert.IsType<string>(result.First().ImxPost);
                    Assert.IsType<User>(result.First().User);
                    Assert.IsType<Post>(result.First());
                }
                );
        }
    }
}
