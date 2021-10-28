using APIComplexEntityFramework.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.ModelDTO.DTOs.Reader
{
    public class PostReaderDTOTest
    {
        PostReaderDTO _postReader = new PostReaderDTO();
        UserReaderDTO _UserReader = new UserReaderDTO();

        [Fact]
        public void TestPostReaderCtor()
        {
            Assert.NotNull(_postReader);
            Assert.IsType<PostReaderDTO>(_postReader);
        }

        [Fact]
        public void TestPostReaderParameters()
        {

            _postReader.ImxPost = "Sample";
            _postReader.Rate = 0;
            _postReader.User = _UserReader;

            Assert.Equal(0, _postReader.Rate);
            Assert.Equal("Sample", _postReader.ImxPost);
            Assert.Equal(_UserReader, _postReader.User);
        }
    }
}
