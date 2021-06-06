using AutoMapper;
using AutoMapper.EquivalencyExpression;
using Sportivo4ka.Users.Data;
using Sportivo4ka.Users.Data.Entity;
using System;
using System.Linq;

namespace Sportivo4ka.Users.API.Configurations.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // CreateMap<ClassDTO, ClassEntity>();
        }
    }
}
