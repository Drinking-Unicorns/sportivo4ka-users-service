using AutoMapper;
using AutoMapper.Collection;
using AutoMapper.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sportivo4ka.Users.Data.ViewModels.Input;

namespace Sportivo4ka.Users.API.Controllers
{
    [ApiController]
    [Route("users/[Controller]")]
    public class ActivityController : ControllerBase
    {
        private readonly ILogger<ActivityController> _logger;
        private readonly IMapper _mapper;

        public ActivityController(ILogger<ActivityController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost("add-points")]
        public async Task<IActionResult> AddPoints([FromBody] AddPointsViewModel model)
        {
            return Ok();
        }

        [HttpPost("add-to-event")]
        public async Task<IActionResult> AddToEvent([FromBody] AddEventViewModel model)
        {
            return Ok();
        }
    }
}
