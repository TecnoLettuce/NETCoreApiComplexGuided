
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
    public class TestPostRepositoryDeletePostAsync
    {

        private readonly ApiContext _context;

        [Fact]
        public void TestPostRepositoryDeletePostAsyncReturnsSomething()
        {

            APIComplexEntityFramework.Data.Repositories.PostRepository postRepository = new APIComplexEntityFramework.Data.Repositories.PostRepository(_context);

            Post postToInsert = new Post();
            postToInsert.PostId = 0;
            postToInsert.UserId = 0;
            postToInsert.Rate = 0;
            postToInsert.ImxPost = "Sample";

            Task task = postRepository.CreatePostAsync(postToInsert).ContinueWith(
                innserTask =>
                {
                    bool result = innserTask.Result;
                    Assert.True(result);
                }
                );

            Task task2 = postRepository.DeletePostAsync(postToInsert).ContinueWith(
                innserTask =>
                {
                    bool result = innserTask.Result;
                    Assert.True(result);
                }
                );
        }
    }
}
