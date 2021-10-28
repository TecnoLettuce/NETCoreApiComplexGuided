using APIComplexEntityFramework.ModelDTO.Writter;
using APIComplexEntityFramework.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.ModelDTO.Mapping.WritterPU
{
    public class AutoMapperUserWritterProfile : Profile
    {
        public AutoMapperUserWritterProfile()
        {
            CreateMap<UserWritterDTO, User>().ReverseMap();
        }
    }
}
