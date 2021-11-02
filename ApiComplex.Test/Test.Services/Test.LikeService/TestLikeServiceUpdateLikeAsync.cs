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

namespace ApiComplex.Test.Test.Services.Test.LikeService
{
    public class TestLikeServiceUpdateLikeAsync
    {
        private readonly ILikeRepository _likeRepository;
        private readonly IMapper _mapper;

        [Fact]
        public void TestUpdateLikeAsyncMethod()
        {
            APIComplexEntityFramework.Services.LikeService likeService = new APIComplexEntityFramework.Services.LikeService(_mapper, _likeRepository);

            LikeWritterDTO dto = new LikeWritterDTO();
            dto.LikeId = 0;
            dto.PostId = 0;
            dto.UserId = 0;

            Task task = likeService.CreateLikeAsync(dto).ContinueWith(
                    innerTask =>
                    {
                        bool result = innerTask.Result;
                        Assert.True(result);
                        Assert.IsType<bool>(result);
                    }
                );


            LikeWritterDTO UpdaterDTO = new LikeWritterDTO();
            UpdaterDTO.LikeId = dto.LikeId;
            UpdaterDTO.PostId = 1;
            UpdaterDTO.UserId = 1;

            Assert.True(UpdaterDTO.LikeId == dto.LikeId);

            Task task2 = likeService.UpdateLikeAsync(UpdaterDTO).ContinueWith(
                    innerTask =>
                    {
                        bool result = innerTask.Result;
                        Assert.True(result);
                        Assert.IsType<bool>(result);
                    }
                );

            Task task3 = likeService.GetLikeByIdAsync(UpdaterDTO.LikeId).ContinueWith(
                innerTask =>
                    {
                        LikeReaderDTO result = innerTask.Result;
                        Assert.True(result.UserId == UpdaterDTO.UserId);
                        Assert.True(result.PostId == UpdaterDTO.PostId);
                    }
                );

        }

    }
}
