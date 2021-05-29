using Marshall.Application.Position;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marshall.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : ControllerBase
    {
        private readonly IPositionQueries _positionQueries;

        public PositionController(IPositionQueries positionQueries)
        {
            _positionQueries = positionQueries;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_positionQueries.GetAllAsync().Result);
        }
    }
}
