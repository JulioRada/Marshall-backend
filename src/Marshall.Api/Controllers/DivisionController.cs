using Marshall.Application.Division;
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
    public class DivisionController : ControllerBase
    {
        private readonly IDivisionQueries _divisionQueries;
        public DivisionController(IDivisionQueries divisionQueries)
        {
            _divisionQueries = divisionQueries;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_divisionQueries.GetAllAsync().Result);
        }
    }
}
