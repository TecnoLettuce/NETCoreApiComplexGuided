using APIComplexEntityFramework.ModelDTO.Writter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.ModelDTO.DTOs.WritterPU
{
    public class PostWritterDTOTest
    {

        PostWritterDTO _postWritter = new PostWritterDTO();

        [Fact]
        public void TestPostWritterCtor()
        {
            Assert.NotNull(_postWritter);
            Assert.IsType<PostWritterDTO>(_postWritter);
        }

        [Fact]
        public void TestPostWritterParameters()
        {

            _postWritter.ImxPost = "Sample";
            _postWritter.Rate = 0;
            _postWritter.UserId = 0;
            _postWritter.PostId = 0;

            Assert.Equal(0, _postWritter.Rate);
            Assert.Equal("Sample", _postWritter.ImxPost);
            Assert.Equal(0, _postWritter.PostId);
            Assert.Equal(0, _postWritter.UserId);
        }
    }
}
