using FluentValidation;
using Marshall.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marshall.Domain.Commands.Salary.Validators
{
    public abstract class SalaryCommandValidatorBase<T> : AbstractValidator<T> where T : CreateSalaryCommand
    {
        private readonly ISalaryRepository _salaryRepository;

        protected SalaryCommandValidatorBase(ISalaryRepository salaryRepository)
        {
            _salaryRepository = salaryRepository;

            ValidateFullName();
        }
        protected void ValidateFullName()
        {
            RuleFor(s => s)
                .MustAsync(async (salaryArgs, cancellationToken) => !(await _salaryRepository.ExistEmployeeAsync(salaryArgs.EmployeeName, salaryArgs.EmployeeSurname)))
                .WithSeverity(Severity.Error)
                .WithMessage("The employee with that name already exists.");
        }
    }
}
