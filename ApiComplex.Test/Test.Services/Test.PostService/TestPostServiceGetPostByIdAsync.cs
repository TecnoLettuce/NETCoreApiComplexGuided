using APIComplexEntityFramework.Data.Repositories;
using APIComplexEntityFramework.ModelDTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.Services.Test.PostService
{
    public class TestPostServiceGetPostByIdAsync
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        [Fact]
        public void TestGetPostByIdAsyncReturnSomething()
        {
            APIComplexEntityFramework.Services.PostService postService = new APIComplexEntityFramework.Services.PostService(_postRepository, _mapper);

            Task<PostReaderDTO> ReturnedFromService = postService.GetPostByIdAsync(0);
            Assert.NotNull(ReturnedFromService);
            Assert.IsType<Task<PostReaderDTO>>(ReturnedFromService);

            Task task = postService.GetPostByIdAsync(0).ContinueWith(
                    innerTask =>
                    {
                        PostReaderDTO result = innerTask.Result;
                        Assert.IsType<string>(result.ImxPost);
                        Assert.IsType<Int32>(result.Rate);
                        Assert.IsType<UserReaderDTO>(result.User);
                        Assert.IsType<string>(result.User.Username);
                        Assert.IsType<string>(result.User.Password);

                    }
                );
        }
    }
}
