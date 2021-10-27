using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIComplexEntityFramework.Models;
using AutoMapper;


namespace APIComplexEntityFramework.ModelDTO.Mapping
{
    public class AutoMapperLikeProfile : Profile
    {
        public AutoMapperLikeProfile()
        {
            CreateMap<LikeDTO, Like>().ReverseMap();
        }

    }
}
