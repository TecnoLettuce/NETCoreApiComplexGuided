using APIComplexEntityFramework.ModelDTO.Writter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.ModelDTO.DTOs.WritterPU
{
    public class LikeWritterDTOTest
    {
        LikeWritterDTO _likeWritter = new LikeWritterDTO();

        [Fact]
        public void TestLikeWritterCtor()
        {
            Assert.NotNull(_likeWritter);
            Assert.IsType<LikeWritterDTO>(_likeWritter);
        }

        [Fact]
        public void TestLikeWritterParameters()
        {

            _likeWritter.LikeId = 0;
            _likeWritter.UserId = 0;
            _likeWritter.PostId = 0;

            Assert.Equal(0, _likeWritter.LikeId);
            Assert.Equal(0, _likeWritter.PostId);
            Assert.Equal(0, _likeWritter.UserId);
        }
    }
}
