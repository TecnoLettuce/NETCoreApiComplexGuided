using APIComplexEntityFramework.Data.Repositories;
using APIComplexEntityFramework.ModelDTO.Eraser;
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
    public class TestUserServiceDeleteUserAsync
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        [Fact]
        public void TestDeleteUserAsyncReturnSomething()
        {
            APIComplexEntityFramework.Services.UserService userService = new APIComplexEntityFramework.Services.UserService(_userRepository, _mapper);

            UserWritterDTO userWritter = new UserWritterDTO();
            userWritter.UserId = 0;
            userWritter.Username = "Sample";
            userWritter.Password = "Sample";

            Task<bool> ReturnedFromService = userService.CreateUserAsync(userWritter);
            Assert.NotNull(ReturnedFromService);
            Assert.IsType<Task<bool>>(ReturnedFromService);

            UserEraserDTO eraser = new UserEraserDTO();
            eraser.UserId = userWritter.UserId;

            Task task = userService.DeleteUserAsync(eraser).ContinueWith(
                    innerTask =>
                    {
                        bool result = innerTask.Result;
                        Assert.True(result);
                    }
                );
        }
    }
}
