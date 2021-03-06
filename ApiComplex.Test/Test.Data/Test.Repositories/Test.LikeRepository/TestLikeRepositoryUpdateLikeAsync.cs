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
    public class TestLikeRepositoryUpdateLikeAsync
    {
        private readonly ApiContext _context;

        [Fact]
        public void TestUpdateLikeResturnsSomething()
        {
            APIComplexEntityFramework.Data.Repositories.LikeRepository likeRepository = new APIComplexEntityFramework.Data.Repositories.LikeRepository(_context);

            Like likeToCreate = new Like();
            likeToCreate.PostId = 0;
            likeToCreate.LikeId = 0;
            likeToCreate.UserId = 0;

            likeToCreate.Post = new Post();
            likeToCreate.Post.PostId = 0;
            likeToCreate.Post.Rate = 0;
            likeToCreate.Post.UserId = 0;

            likeToCreate.User = new User();
            likeToCreate.User.UserId = 0;
            likeToCreate.User.Username = "Sample";
            likeToCreate.User.Password = "Sample";

            Task task = likeRepository.CreateLikeAsync(likeToCreate).ContinueWith(
                innserTask =>
                {
                    bool result = innserTask.Result;
                    Assert.True(result);
                }
                );

            likeToCreate.PostId = 1;
            likeToCreate.UserId = 1;

            Task task2 = likeRepository.UpdateLikeAsync(likeToCreate).ContinueWith(
                innserTask =>
                {
                    bool result = innserTask.Result;
                    Assert.True(result);
                }
                );

        }
    }
}
