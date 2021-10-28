using APIComplexEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.Data.Test.Models
{
    public class LikeTest
    {
        Like _like = new Like();
        Post _post = new Post();
        User _user = new User();

        [Fact]
        public void TestLikeCtor()
        {
            Assert.NotNull(_like);
            Assert.IsType<Like>(_like);
        }

        [Fact]
        public void TestLikeParameters()
        {

            _like.LikeId = 0;
            _like.PostId = 0;
            _like.UserId = 0;

            _like.Post = _post;
            _like.User = _user;

            Assert.NotNull(_like);
            Assert.NotNull(_like.User);
            Assert.NotNull(_like.Post);
            Assert.Equal(0, _like.LikeId);
            Assert.Equal(0, _like.UserId);
            Assert.Equal(0, _like.PostId);

        }

    }
}
