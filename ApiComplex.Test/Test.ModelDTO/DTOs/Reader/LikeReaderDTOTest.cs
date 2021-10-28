using APIComplexEntityFramework.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.ModelDTO.DTOs.Reader
{
    public class LikeReaderDTOTest
    {
        LikeReaderDTO _likeReader = new LikeReaderDTO();

        [Fact]
        public void TestLikeReaderCtor()
        {
            Assert.NotNull(_likeReader);
            Assert.IsType<LikeReaderDTO>(_likeReader);
        }

        [Fact]
        public void TestLikeReaderParameters()
        {

            _likeReader.PostId = 0;
            _likeReader.UserId = 0;

            Assert.Equal(0, _likeReader.UserId);
            Assert.Equal(0, _likeReader.PostId);
        }
    }
}
