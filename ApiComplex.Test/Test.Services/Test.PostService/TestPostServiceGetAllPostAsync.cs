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
    public class TestPostServiceGetAllPostAsync
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        [Fact]
        public void TestGetAllPostAsyncReturnSomething()
        {
            APIComplexEntityFramework.Services.PostService postService = new APIComplexEntityFramework.Services.PostService(_postRepository, _mapper);

            Task<IEnumerable<PostReaderDTO>> ReturnedFromService = postService.GetAllPostAsync();
            Assert.NotNull(ReturnedFromService);
            Assert.IsType<Task<IEnumerable<PostReaderDTO>>>(ReturnedFromService);

            Task task = postService.GetAllPostAsync().ContinueWith(
                    innerTask =>
                    {
                        IEnumerable<PostReaderDTO> result = innerTask.Result;
                        Assert.True(result.Count() > 0);
                    }
                );
        }
    }
}
