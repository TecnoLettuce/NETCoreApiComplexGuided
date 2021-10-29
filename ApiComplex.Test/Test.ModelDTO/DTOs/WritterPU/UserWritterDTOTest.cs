using APIComplexEntityFramework.ModelDTO.Writter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.ModelDTO.DTOs.WritterPU
{
    public class UserWritterDTOTest
    {
        UserWritterDTO _userWritter = new UserWritterDTO();

        [Fact]
        public void TestUserWritterCtor()
        {
            Assert.NotNull(_userWritter);
            Assert.IsType<UserWritterDTO>(_userWritter);
        }

        [Fact]
        public void TestUserWritterParameters()
        {

            _userWritter.UserId = 0;
            _userWritter.Username = "Sample";
            _userWritter.Password = "Sample";

            Assert.Equal(0, _userWritter.UserId);
            Assert.Equal("Sample", _userWritter.Username);
            Assert.Equal("Sample", _userWritter.Password);
        }
    }
}
