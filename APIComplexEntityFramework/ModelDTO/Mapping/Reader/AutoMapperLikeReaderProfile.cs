using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIComplexEntityFramework.Models;
using AutoMapper;


namespace APIComplexEntityFramework.ModelDTO.Mapping
{
    public class AutoMapperLikeReaderProfile : Profile
    {
        public AutoMapperLikeReaderProfile()
        {
            CreateMap<LikeReaderDTO, Like>().ReverseMap();
        }

    }
}
