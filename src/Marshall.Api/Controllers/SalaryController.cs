using Marshall.Application.Salary;
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
        private readonly ISalaryQueries _salaryQueries;

        public SalaryController(ICommandHandler<CreateSalaryCommand> createSalaryCommandHandler, ISalaryQueries salaryQueries)
        {
            _createSalaryCommandHandler = createSalaryCommandHandler;
            _salaryQueries = salaryQueries;
        }

        [HttpPost]
        public IActionResult Post(CreateSalaryCommand command)
        {
            return Ok(_createSalaryCommandHandler.Handle(command));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_salaryQueries.GetAllAsync().Result);
        }
        
        [HttpGet]
        [Route("EmployeeCode/{employeeCode}/{records}")]
        public IActionResult GetByEmployeeCode(string employeeCode, int records)
        {
            return Ok(_salaryQueries.GetSalaryByEmployeeCodeAsync(employeeCode, records).Result);
        }
    }
}
