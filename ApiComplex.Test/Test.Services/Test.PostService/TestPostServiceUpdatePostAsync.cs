using APIComplexEntityFramework.Data.Repositories;
using APIComplexEntityFramework.ModelDTO;
using APIComplexEntityFramework.ModelDTO.Writter;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.Services.Test.PostService
{
    public class TestPostServiceUpdatePostAsync
    {

        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        [Fact]
        public void TestUpdatePostAsyncReturnSomething()
        {
            APIComplexEntityFramework.Services.PostService postService = new APIComplexEntityFramework.Services.PostService(_postRepository, _mapper);
            PostWritterDTO dto = new PostWritterDTO();
            dto.PostId = 0;
            dto.Rate = 0;
            dto.ImxPost = "Sample";
            dto.UserId = 0;


            Task<bool> ReturnedFromService = postService.CreatePostAsync(dto);
            Assert.NotNull(ReturnedFromService);
            Assert.IsType<Task<bool>>(ReturnedFromService);

            Task task = postService.CreatePostAsync(dto).ContinueWith(
                    innerTask =>
                    {
                        bool result = innerTask.Result;
                        Assert.True(result);
                    }
                );

            PostWritterDTO postUpdater = new PostWritterDTO();
            postUpdater.PostId = dto.PostId;
            postUpdater.ImxPost = "Changed";
            postUpdater.Rate = 1;
            postUpdater.UserId = 1;

            Assert.True(postUpdater.PostId == dto.PostId);

            Task task2 = postService.UpdatePostAsync(postUpdater).ContinueWith(
                    innerTask =>
                    {
                        bool result = innerTask.Result;
                        Assert.True(result);
                    }
                );

            Task task3 = postService.GetPostByIdAsync(postUpdater.PostId).ContinueWith(
                    innerTask =>
                    {
                        PostReaderDTO result = innerTask.Result;
                        Assert.True(result.ImxPost == postUpdater.ImxPost);
                        Assert.True(result.Rate == postUpdater.Rate);
                    }
                );


        }
    }
}
