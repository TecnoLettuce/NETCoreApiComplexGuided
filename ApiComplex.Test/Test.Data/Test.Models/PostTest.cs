using APIComplexEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.Data.Test.Models
{
    public class PostTest
    {
        Post _post = new Post();
        User _user = new User();

        [Fact]
        public void TestPostCtor() {

            Assert.NotNull(_post);
            Assert.IsType<Post>(_post);
        }

        [Fact]
        public void TestPostParameters() {

            _post.ImxPost = "Sample";
            _post.PostId = 1;
            _post.Rate = 0;

            _post.User = _user;
            _post.UserId = 1;

            Assert.NotNull(_post);
            Assert.Equal(1, _post.PostId);
            Assert.Equal(1, _post.UserId);
            Assert.Equal(_user, _post.User);
            Assert.Equal(0, _post.Rate);
            Assert.Equal("Sample", _post.ImxPost);
        }
    }
}
