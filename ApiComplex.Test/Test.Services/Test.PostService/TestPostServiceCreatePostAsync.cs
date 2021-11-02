using APIComplexEntityFramework.Data.Repositories;
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
    public class TestPostServiceCreatePostAsync
    {

        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        [Fact]
        public void TestCreatePostAsyncReturnSomething()
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
        }
    }
}
