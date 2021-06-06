using AutoMapper;
using Newtonsoft.Json.Linq;
using Sportivo4ka.Users.BI.Options;
using Sportivo4ka.Users.Data.Entity;
using Sportivo4ka.Users.General.Expansions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Sportivo4ka.Users.API.Configurations.AutoMapper
{
    public class FormatterObjectToString : IValueResolver<object, object, string>
    {
        private readonly IMapper _mapper;

        public FormatterObjectToString(IMapper mapper)
        {
            _mapper = mapper;
        }

        public string Resolve(object source, object destination, string result, ResolutionContext context)
        {
            return result;
        }
    }

}