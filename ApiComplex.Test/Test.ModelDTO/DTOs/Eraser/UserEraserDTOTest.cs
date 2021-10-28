using APIComplexEntityFramework.ModelDTO.Eraser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.ModelDTO.DTOs.Eraser
{
    public class UserEraserDTOTest
    {
        UserEraserDTO _userEraser = new UserEraserDTO();

        [Fact]
        public void TestUserEraserCtor()
        {
            Assert.NotNull(_userEraser);
            Assert.IsType<UserEraserDTO>(_userEraser);
        }

        [Fact]
        public void TestUserEraserParameters()
        {

            _userEraser.UserId = 0;

            Assert.Equal(0, _userEraser.UserId);
        }
    }
}
