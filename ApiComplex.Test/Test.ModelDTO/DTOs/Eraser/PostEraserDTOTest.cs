using APIComplexEntityFramework.ModelDTO.Eraser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.ModelDTO.DTOs.Eraser
{
    public class PostEraserDTOTest
    {
        PostEraserDTO _postEraser = new PostEraserDTO();

        [Fact]
        public void TestPostEraserCtor()
        {
            Assert.NotNull(_postEraser);
            Assert.IsType<PostEraserDTO>(_postEraser);
        }

        [Fact]
        public void TestPostParameters()
        {

            _postEraser.PostId = 0;

            Assert.Equal(0, _postEraser.PostId);
        }
    }
}
