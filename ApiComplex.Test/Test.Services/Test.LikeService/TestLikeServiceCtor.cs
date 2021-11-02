using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIComplexEntityFramework;
using APIComplexEntityFramework.Data.Repositories;
using APIComplexEntityFramework.Services;
using AutoMapper;
using Xunit;

namespace ApiComplex.Test.Test.Services.Test.LikeService
{
    public class TestLikeServiceCtor
    {
        private readonly ILikeRepository _likeRepository;
        private readonly IMapper _mapper;

        [Fact]
        public void TestServiceCtor()
        {
            APIComplexEntityFramework.Services.LikeService likeService = new APIComplexEntityFramework.Services.LikeService(_mapper, _likeRepository);

            Assert.NotNull(likeService);
            Assert.IsType<APIComplexEntityFramework.Services.LikeService>(likeService);
            Assert.IsType<APIComplexEntityFramework.Services.LikeService>(likeService);
        }
    }
}
