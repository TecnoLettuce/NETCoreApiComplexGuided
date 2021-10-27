using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIComplexEntityFramework.Models;
using AutoMapper;

namespace APIComplexEntityFramework.ModelDTO.Mapping
{
    public class AutoMapperPostProfile : Profile
    {
        public AutoMapperPostProfile()
        {
            CreateMap<PostDTO, Post>().ReverseMap();
        }
    }
}
