using APIComplexEntityFramework.Data.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.Services.Test.UserService
{
    public class TestUserServiceCtor
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        [Fact]
        public void TestServiceCtor()
        {
            APIComplexEntityFramework.Services.UserService userService = new APIComplexEntityFramework.Services.UserService(_userRepository, _mapper);

            Assert.NotNull(userService);
            Assert.IsType<APIComplexEntityFramework.Services.UserService>(userService);
        }
    }
}
