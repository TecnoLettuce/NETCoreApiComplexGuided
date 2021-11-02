using APIComplexEntityFramework.Data.Repositories;
using APIComplexEntityFramework.ModelDTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.Services.Test.LikeService
{
    public class TestLikeServiceGetAllLikesByUserIdAsync
    {
        private readonly ILikeRepository _likeRepository;
        private readonly IMapper _mapper;


        [Fact]
        public void TestGetAllLikesByUserIdAsyncReturnSomething()
        {
            APIComplexEntityFramework.Services.LikeService likeService = new APIComplexEntityFramework.Services.LikeService(_mapper, _likeRepository);

            Task<IEnumerable<LikeReaderDTO>> ReturnedFromService = likeService.GetAllLikesByUserIdAsync(0);
            Assert.NotNull(ReturnedFromService);
            Assert.IsType<Task<IEnumerable<LikeReaderDTO>>>(ReturnedFromService);

            Task task = likeService.GetAllLikesAsync().ContinueWith(
                    innerTask =>
                    {
                        IEnumerable<LikeReaderDTO> result = innerTask.Result;
                        Assert.True(result.Count() > 0);
                        Assert.True(result.First().UserId == 0);
                        Assert.IsType<Int32>(result.First().PostId);
                        Assert.IsType<Int32>(result.First().UserId);
                    }
                );
        }
    }
}
