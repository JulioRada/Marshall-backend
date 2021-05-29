using Marshall.Application.Office;
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
    public class OfficeController : ControllerBase
    {
        private readonly IOfficeQueries _officeQueries;
        public OfficeController(IOfficeQueries officeQueries)
        {
            _officeQueries = officeQueries;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_officeQueries.GetAllAsync().Result);
        }
    }
}
