using APIComplexEntityFramework.ModelDTO.Eraser;
using APIComplexEntityFramework.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.ModelDTO.Mapping.Eraser
{
    public class AutoMapperLikeEraserProfile : Profile
    {
        public AutoMapperLikeEraserProfile()
        {
            CreateMap<LikeEraserDTO, Like>().ReverseMap();
        }
    }
}
