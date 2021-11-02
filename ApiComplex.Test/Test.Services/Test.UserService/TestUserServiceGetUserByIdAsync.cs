using APIComplexEntityFramework.Data.Repositories;
using APIComplexEntityFramework.ModelDTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.Services.Test.UserService
{
    public class TestUserServiceGetUserByIdAsync
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        [Fact]
        public void TestGetUserByIdAsyncReturnSomething()
        {
            APIComplexEntityFramework.Services.UserService userService = new APIComplexEntityFramework.Services.UserService(_userRepository, _mapper);


            Task<UserReaderDTO> ReturnedFromService = userService.GetUserByIdAsync(0);
            Assert.NotNull(ReturnedFromService);
            Assert.IsType<Task<UserReaderDTO>>(ReturnedFromService);

            Task task = userService.GetUserByIdAsync(0).ContinueWith(
                    innerTask =>
                    {
                        UserReaderDTO result = innerTask.Result;
                        Assert.NotNull(result);
                        Assert.IsType<string>(result.Password);
                        Assert.IsType<string>(result.Username);
                    }
                );
        }

    }
}

