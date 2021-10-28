using APIComplexEntityFramework.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.ModelDTO.DTOs.Reader
{
    public class UserReaderDTOTest
    {
        UserReaderDTO _UserReader = new UserReaderDTO();

        [Fact]
        public void TestUserReaderCtor()
        {
            Assert.NotNull(_UserReader);
            Assert.IsType<UserReaderDTO>(_UserReader);
        }

        [Fact]
        public void TestUserReaderParameters()
        {

            _UserReader.Username = "Sample";
            _UserReader.Password = "Sample";

            Assert.Equal("Sample", _UserReader.Username);
            Assert.Equal("Sample", _UserReader.Password);
        }
    }
}
