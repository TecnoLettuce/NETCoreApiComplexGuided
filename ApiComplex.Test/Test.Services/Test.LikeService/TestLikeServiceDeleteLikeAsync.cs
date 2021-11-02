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

namespace ApiComplex.Test.Test.Services.Test.LikeService
{
    public class TestLikeServiceDeleteLikeAsync
    {
        private readonly ILikeRepository _likeRepository;
        private readonly IMapper _mapper;

        [Fact]
        public void TestDeleteLikeAsyncMethod()
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
            LikeEraserDTO eraserDTO = new LikeEraserDTO();
            eraserDTO.LikeId = dto.LikeId;

            Assert.True(eraserDTO.LikeId == dto.LikeId);

            Task task2 = likeService.DeleteLikeAsync(eraserDTO).ContinueWith(
                    innerTask =>
                    {
                        bool result = innerTask.Result;
                        Assert.True(result);
                        Assert.IsType<bool>(result);
                    }
                );

        }
    }
}
