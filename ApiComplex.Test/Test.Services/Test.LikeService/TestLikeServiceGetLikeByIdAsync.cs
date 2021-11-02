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
    public class TestLikeServiceGetLikeByIdAsync
    {
        private readonly ILikeRepository _likeRepository;
        private readonly IMapper _mapper;


        [Fact]
        public void TestGetLikeByIdAsyncReturnSomething()
        {
            APIComplexEntityFramework.Services.LikeService likeService = new APIComplexEntityFramework.Services.LikeService(_mapper, _likeRepository);

            Task<LikeReaderDTO> ReturnedFromService = likeService.GetLikeByIdAsync(0);
            Assert.NotNull(ReturnedFromService);
            Assert.IsType<Task<LikeReaderDTO>>(ReturnedFromService);

            Task task = likeService.GetAllLikesAsync().ContinueWith(
                    innerTask =>
                    {
                        IEnumerable<LikeReaderDTO> Result = innerTask.Result;
                        Assert.NotNull(Result);
                        Assert.True(Result.Count() < 2);
                        Assert.True(Result.Count() > 0);
                        Assert.True(Result.First().PostId == 0);
                        Assert.True(Result.First().UserId > -1);
                    }
                );
        }
    }
}
