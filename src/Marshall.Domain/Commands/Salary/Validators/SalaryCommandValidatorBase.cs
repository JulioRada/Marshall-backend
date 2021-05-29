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
            validateRequiredDetailList();
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
                .MustAsync(async (salaryArgs, cancellationToken) =>
                {

                    var salaryDate = await _salaryRepository.GetSalaryByEmployeeCodeAsync(salaryArgs.EmployeeCode);

                    if (salaryDate == null) return false;

                    var ex = salaryArgs.detailSalary.Where(d => salaryDate.Exists(s => s.Year == d.Year && s.Month == d.Month)).ToList();

                    return !ex.Any();
                })
                .WithSeverity(Severity.Error)
                .WithMessage("There are one or more employees registered in the month and year.");
        }
        protected void ValidateSalary()
        {
            RuleFor(s => s.BeginDate)
                .NotEmpty()
                .WithSeverity(Severity.Error)
                .WithMessage("Begin date is required.")
                .Must((date) => !date.Equals(default(DateTime)))
                .WithSeverity(Severity.Error)
                .WithMessage("Begin date is not date valid.")
                .Must((date) => DateTime.Compare(date, DateTime.Now) < 0)
                .WithSeverity(Severity.Error)
                .WithMessage("Begin date greater than the current date.");

            RuleFor(s => s.Birthday)
                .NotEmpty()
                .WithSeverity(Severity.Error)
                .WithMessage("Birthday is required.")
                .Must((date) => !date.Equals(default(DateTime)))
                .WithSeverity(Severity.Error)
                .WithMessage("Birthday is not date valid.")
                .Must((date) => DateTime.Compare(date, DateTime.Now) < 0)
                .WithSeverity(Severity.Error)
                .WithMessage("Birthday greater than the current date.");

            RuleFor(s => s.EmployeeCode)
                .NotEmpty()
                .WithSeverity(Severity.Error)
                .WithMessage("Employee code required.")
                .MaximumLength(10)
                .WithSeverity(Severity.Error)
                .WithMessage("Employee code too long.");

            RuleFor(s => s.EmployeeName)
                .NotEmpty()
                .WithSeverity(Severity.Error)
                .WithMessage("Employee name required.")
                .MaximumLength(150)
                .WithSeverity(Severity.Error)
                .WithMessage("Employee Name too long.");

            RuleFor(s => s.EmployeeSurname)
                .NotEmpty()
                .WithSeverity(Severity.Error)
                .WithMessage("Employee surname required.")
                .MaximumLength(150)
                .WithSeverity(Severity.Error)
                .WithMessage("Employee surname too long.");

            RuleFor(s => s.IdentificationNumber)
                .NotEmpty()
                .WithSeverity(Severity.Error)
                .WithMessage("Identification number required.")
                .MaximumLength(10)
                .WithSeverity(Severity.Error)
                .WithMessage("Identification number too long.");
        }

        protected void validateRequiredDetailList()
        {

            RuleFor(s => s.detailSalary)
                .NotEmpty()
                .WithSeverity(Severity.Error)
                .WithMessage("You must register at least one record in the detail.");

            RuleForEach(s => s.detailSalary)
                .SetValidator(new DetailSalaryValidator());

        }
    }

    public class DetailSalaryValidator : AbstractValidator<DetailSalaryCommand>
    {
        public DetailSalaryValidator()
        {
            RuleFor(d => d.Year).InclusiveBetween(1970, 2999).WithMessage("The year: {PropertyValue} must be a year within the allowed range.");
            RuleFor(d => d.Month).InclusiveBetween(1, 12).WithMessage("The month: {PropertyValue} must be a month valid.");

            RuleFor(d => d.Division).GreaterThanOrEqualTo(0).WithMessage("The division: {PropertyValue} must be a positive value.");
            RuleFor(d => d.Office).GreaterThanOrEqualTo(0).WithMessage("The office: {PropertyValue} must be a positive value.");
            RuleFor(d => d.Position).GreaterThanOrEqualTo(0).WithMessage("The position: {PropertyValue} must be a positive value.");

            RuleFor(d => d.Grade).GreaterThanOrEqualTo(0).WithMessage("The grade: {PropertyValue} must be a positive value.");

        }
    }
}
