using APIComplexEntityFramework.Data.Repositories;
using APIComplexEntityFramework.ModelDTO;
using APIComplexEntityFramework.ModelDTO.Writter;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.Services.Test.UserService
{
    public class TestUserServiceCreateUserAsync
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        [Fact]
        public void TestCreateUserAsyncReturnSomething()
        {
            APIComplexEntityFramework.Services.UserService userService = new APIComplexEntityFramework.Services.UserService(_userRepository, _mapper);

            UserWritterDTO userWritter = new UserWritterDTO();
            userWritter.UserId = 0;
            userWritter.Username = "Sample";
            userWritter.Password = "Sample";

            Task<bool> ReturnedFromService = userService.CreateUserAsync(userWritter);
            Assert.NotNull(ReturnedFromService);
            Assert.IsType<Task<bool>>(ReturnedFromService);

            Task task = userService.CreateUserAsync(userWritter).ContinueWith(
                    innerTask =>
                    {
                        bool result = innerTask.Result;
                        Assert.True(result);
                    }
                );

            Task task2 = userService.GetUserByIdAsync(userWritter.UserId).ContinueWith(
                    innerTask =>
                    {
                        UserReaderDTO result = innerTask.Result;
                        Assert.True(result.Username == userWritter.Username);
                        Assert.True(result.Password == userWritter.Password);
                    }
                );
        }
    }
}
