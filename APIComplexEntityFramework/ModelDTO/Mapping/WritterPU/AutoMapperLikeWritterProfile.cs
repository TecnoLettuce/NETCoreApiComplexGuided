using APIComplexEntityFramework.ModelDTO.Writter;
using APIComplexEntityFramework.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.ModelDTO.Mapping.WritterPU
{
    public class AutoMapperLikeWritterProfile : Profile
    {
        public AutoMapperLikeWritterProfile()
        {
            CreateMap<LikeWritterDTO, Like>().ReverseMap();
        }
    }
}
