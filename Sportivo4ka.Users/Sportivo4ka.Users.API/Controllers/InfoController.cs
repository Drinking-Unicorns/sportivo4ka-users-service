using AutoMapper;
using AutoMapper.Collection;
using AutoMapper.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sportivo4ka.Users.API.Controllers
{
    [ApiController]
    [Route("users/[Controller]")]
    public class InfoController : ControllerBase
    {
        private readonly ILogger<InfoController> _logger;
        private readonly IMapper _mapper;

        public InfoController(ILogger<InfoController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("points")]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}
