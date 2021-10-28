using APIComplexEntityFramework.ModelDTO.Eraser;
using APIComplexEntityFramework.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.ModelDTO.Mapping.Eraser
{
    public class AutoMapperUserEraserProfile : Profile
    {
        public AutoMapperUserEraserProfile()
        {
            CreateMap<UserEraserDTO, User>().ReverseMap();
        }
    }
}
