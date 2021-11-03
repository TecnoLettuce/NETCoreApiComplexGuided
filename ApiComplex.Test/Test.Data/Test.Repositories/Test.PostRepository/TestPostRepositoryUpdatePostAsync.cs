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
    public class TestPostRepositoryUpdatePostAsync
    {
        private readonly ApiContext _context;

        [Fact]
        public void TestPostRepositoryUpdatePostAsyncReturnsSomething()
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

            postToInsert.ImxPost = "Updated";
            postToInsert.UserId = 1;
            postToInsert.Rate = 1;

            Task task2 = postRepository.UpdatePostAsync(postToInsert).ContinueWith(
                innserTask =>
                {
                    bool result = innserTask.Result;
                    Assert.True(result);
                }
                );

            Task task3 = postRepository.GetPostByIdAsync(postToInsert.PostId).ContinueWith(
                innserTask =>
                {
                    Post result = innserTask.Result;
                    Assert.True(result.PostId == postToInsert.PostId);
                    Assert.True(result.UserId == postToInsert.UserId);
                    Assert.True(result.ImxPost== postToInsert.ImxPost);
                    Assert.True(result.Rate == postToInsert.Rate);
                }
                );
        }
    }
}
