using APIComplexEntityFramework.ModelDTO.Eraser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.ModelDTO.DTOs.Eraser
{
    public class LikeEraserDTOTest
    {
        LikeEraserDTO _likeEraser = new LikeEraserDTO();

        [Fact]
        public void TestLikeEraserCtor()
        {
            Assert.NotNull(_likeEraser);
            Assert.IsType<LikeEraserDTO>(_likeEraser);
        }

        [Fact]
        public void TestLikeEraserParameters()
        {

            _likeEraser.LikeId = 0;

            Assert.Equal(0, _likeEraser.LikeId);
        }
    }
}
