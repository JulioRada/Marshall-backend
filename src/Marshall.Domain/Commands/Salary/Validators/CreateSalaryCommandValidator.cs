using FluentValidation;
using Marshall.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marshall.Domain.Commands.Salary.Validators
{
    public class CreateSalaryCommandValidator : SalaryCommandValidatorBase<CreateSalaryCommand>
    {
        public CreateSalaryCommandValidator(ISalaryRepository salaryRepository)
            : base((salaryRepository))
        {
        }
    }
}
