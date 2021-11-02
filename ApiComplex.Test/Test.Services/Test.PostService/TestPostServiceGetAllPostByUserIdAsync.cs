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
    public class TestPostServiceGetAllPostByUserIdAsync
    {

        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        [Fact]
        public void TestGetAllPostByUserIdAsyncReturnSomething()
        {
            APIComplexEntityFramework.Services.PostService postService = new APIComplexEntityFramework.Services.PostService(_postRepository, _mapper);

            Task<IEnumerable<PostReaderDTO>> ReturnedFromService = postService.GetAllPostsByUserIdAsync(0);
            Assert.NotNull(ReturnedFromService);
            Assert.IsType<Task<IEnumerable<PostReaderDTO>>>(ReturnedFromService);

            Task task = postService.GetAllPostsByUserIdAsync(0).ContinueWith(
                    innerTask =>
                    {
                        IEnumerable<PostReaderDTO> result = innerTask.Result;
                        Assert.True(result.Count() > -1);
                        Assert.IsType<PostReaderDTO>(result.First());
                        Assert.IsType<string>(result.First().ImxPost);
                        Assert.IsType<Int32>(result.First().Rate);
                        Assert.IsType<UserReaderDTO>(result.First().User);
                        Assert.IsType<string>(result.First().User.Password);
                        Assert.IsType<string>(result.First().User.Username);

                    }
                );
        }

    }
}
