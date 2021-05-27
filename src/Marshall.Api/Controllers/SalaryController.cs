using Marshall.Core.Interfaces;
using Marshall.Domain.Commands.Salary;
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
    public class SalaryController : ControllerBase
    {
        private readonly ICommandHandler<CreateSalaryCommand> _createSalaryCommandHandler;

        public SalaryController(ICommandHandler<CreateSalaryCommand> createSalaryCommandHandler)
        {
            _createSalaryCommandHandler = createSalaryCommandHandler;
        }

        [HttpPost]
        public IActionResult Post(CreateSalaryCommand command)
        {
            return Ok(_createSalaryCommandHandler.Handle(command));
        }
    }
}
