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
    public class AdminController : ControllerBase
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IMapper _mapper;

        public AdminController(ILogger<AdminController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost("add-user")]
        public async Task<IActionResult> AddUser()
        {
            return Ok();
        }
    }
}
