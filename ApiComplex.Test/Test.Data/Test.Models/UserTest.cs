using APIComplexEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.Data.Test.Models
{
    public class UserTest
    {
        User _user = new User();


        [Fact]
        public void TestUserCtor()
        {

            Assert.NotNull(_user);
            Assert.IsType<User>(_user);
        }

        [Fact]
        public void TestUserParameters()
        {

            _user.Username = "Sample";
            _user.Password = "Sample";
            _user.UserId = 0;

            Assert.NotNull(_user);
            Assert.Equal(0, _user.UserId);
            Assert.Equal("Sample", _user.Username);
            Assert.Equal("Sample", _user.Password);
        }
    }
}
