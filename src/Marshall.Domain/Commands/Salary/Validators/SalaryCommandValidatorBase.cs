using FluentValidation;
using Marshall.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
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
            ValidateSalaryDateEmployee();
            ValidateSalary();
        }
        protected void ValidateFullName()
        {
            RuleFor(s => s)
                .MustAsync(async (salaryArgs, cancellationToken) => !(await _salaryRepository.ExistEmployeeAsync(salaryArgs.EmployeeName, salaryArgs.EmployeeSurname)))
                .WithSeverity(Severity.Error)
                .WithMessage("The employee with that name already exists.");
        }
        protected void ValidateSalaryDateEmployee()
        {

            RuleFor(s => s)
                .MustAsync(async (salaryArgs, cancellationToken) => {
                    
                    var salaryDate = await _salaryRepository.GetByEmployeeCodeAsync(salaryArgs.EmployeeCode);
                    
                    var ex = salaryArgs.detailSalary.Where(d => salaryDate.Exists(s => s.Year == d.Year && s.Month == d.Month)).ToList();

                    return !ex.Any();
                })
                .WithSeverity(Severity.Error)
                .WithMessage("One or more employee salaries already exist.");
        }
        protected void ValidateSalary()
        {
            RuleFor(s => s.BeginDate)
                .Must((date) => !date.Equals(default(DateTime)))
                .WithSeverity(Severity.Error)
                .WithMessage("Begin date is not date valid")
                .Must((date) => DateTime.Compare(date, DateTime.Now) < 0)
                .WithSeverity(Severity.Error)
                .WithMessage("Date greater than the current date.");
            
            RuleFor(s => s.EmployeeCode)
                .Must((employeeCode) => employeeCode.Length <= 10)
                .WithSeverity(Severity.Error)
                .WithMessage("Employee code too long");

            RuleFor(s => s.EmployeeName)
                .Must((employeeName) => employeeName.Length <= 150)
                .WithSeverity(Severity.Error)
                .WithMessage("Employee Name too long");

            RuleFor(s => s.EmployeeSurname)
                .Must((employeeSurname) => employeeSurname.Length <= 150)
                .WithSeverity(Severity.Error)
                .WithMessage("Employee surname too long");

            RuleFor(s => s.IdentificationNumber)
                .Must((identificationNumber) => identificationNumber.Length <= 10)
                .WithSeverity(Severity.Error)
                .WithMessage("Identification number too long");

        }
    }
}
