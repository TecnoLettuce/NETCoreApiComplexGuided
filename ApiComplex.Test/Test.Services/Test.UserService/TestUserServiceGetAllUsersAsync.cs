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
    public class TestUserServiceGetAllUsersAsync
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        [Fact]
        public void TestGetAllUsersAsyncReturnSomething()
        {
            APIComplexEntityFramework.Services.UserService userService = new APIComplexEntityFramework.Services.UserService(_userRepository, _mapper);


            Task<IEnumerable<UserReaderDTO>> ReturnedFromService = userService.GetAllUsersAsync();
            Assert.NotNull(ReturnedFromService);
            Assert.IsType<Task<IEnumerable<UserReaderDTO>>>(ReturnedFromService);

            Task task = userService.GetAllUsersAsync().ContinueWith(
                    innerTask =>
                    {
                        IEnumerable<UserReaderDTO> result = innerTask.Result;
                        Assert.True(result.Count() > 0);
                    }
                );
        }

    }
}
