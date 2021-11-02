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
    public class TestUserServiceUpdateUserAsync
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        [Fact]
        public void TestUpdateUserAsyncReturnSomething()
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

            UserWritterDTO updater = new UserWritterDTO();
            updater.UserId = userWritter.UserId;
            updater.Username = "Updated";
            updater.Password = "Updated";

            Task task2 = userService.UpdateUserAsync(updater).ContinueWith(
                    innerTask =>
                    {
                        bool result = innerTask.Result;
                        Assert.True(result);
                    }
                );

            Task task3 = userService.GetUserByIdAsync(updater.UserId).ContinueWith(
                    innerTask =>
                    {
                        UserReaderDTO reader = innerTask.Result;
                        Assert.True(reader.Password == updater.Password);
                        Assert.True(userWritter.Password != updater.Password);
                        Assert.True(reader.Username == updater.Username);
                        Assert.True(userWritter.Username != updater.Username);
                    }
                );
        }

    }
}
