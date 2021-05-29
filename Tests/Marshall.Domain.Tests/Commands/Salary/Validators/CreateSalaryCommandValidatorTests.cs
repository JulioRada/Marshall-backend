using Marshall.Domain.Commands.Salary;
using Marshall.Domain.Commands.Salary.Validators;
using Marshall.Domain.Interfaces.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using FluentValidation;

namespace Marshall.Domain.Tests.Commands.Salary.Validators
{
    public class CreateSalaryCommandValidatorTests
    {
        
        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { "1", "123", "julio", "rada", new DateTime(2020,3,5), new DateTime(1996, 10, 4), 
                    new List<DetailSalaryCommand>() {
                        new DetailSalaryCommand() {
                                Year = 2017,
                                Month = 10,
                                Office = 1,
                                Division = 3,
                                Position = 2,
                                Grade = 7,
                                BaseSalary = 120,
                                ProductionBonus = 65,
                                CompensationBonus = 50,
                                Comission = 100,
                                Contributions = 60
                            } 
                        }, 
                    true
                },
                new object[] { "0", "123", "julio", "rada", new DateTime(2020,10,5), new DateTime(1996, 10, 4),
                    new List<DetailSalaryCommand>() {
                        new DetailSalaryCommand() {
                                Year = 2020,
                                Month = 1,
                                Office = 1,
                                Division = 3,
                                Position = -1,
                                Grade = 7,
                                BaseSalary = 120,
                                ProductionBonus = 65,
                                CompensationBonus = 50,
                                Comission = 100,
                                Contributions = 60
                            }
                        },
                    false
                },
                new object[] { "0", "123", "julio", "rada", new DateTime(2020,10,5), new DateTime(1996, 10, 4),
                    new List<DetailSalaryCommand>() { },
                    false
                },
            };

        private readonly Mock<ISalaryRepository> _salaryRepositoryMock;
        private readonly CreateSalaryCommandValidator _createSalaryCommandValidator;
        public CreateSalaryCommandValidatorTests()
        {
            _salaryRepositoryMock = new Mock<ISalaryRepository>();
            _createSalaryCommandValidator = new CreateSalaryCommandValidator(_salaryRepositoryMock.Object);
            
        }

        public void Name_And_Surname_Cant_Be_repeated(string name, string surname, bool exists)
        {
            // Arrange
            var createSalaryCommand = new CreateSalaryCommand() { 
                EmployeeName = name, 
                EmployeeSurname = surname,
                detailSalary = new List<DetailSalaryCommand>()
            };

            _salaryRepositoryMock.Setup(a => a.ExistEmployeeAsync(name, surname)).Returns(Task.FromResult(exists));
            
            // Act
            var validationResults = _createSalaryCommandValidator.Validate(createSalaryCommand);

            // Assert
            validationResults.IsValid.Should().Be(!exists);

        }

        [Theory]
        [MemberData(nameof(Data))]
        public void Should_Command_Valid(
            string identifierNumber, 
            string employeeCode, 
            string employeeName,
            string employeeSurname,
            DateTime beginDate,
            DateTime birthday,
            List<DetailSalaryCommand> detail,
            bool valid
        )
        {
            //Arrange
            var createSalaryCommand = new CreateSalaryCommand
            {
                IdentificationNumber = identifierNumber,
                EmployeeCode = employeeCode,
                EmployeeName = employeeName,
                EmployeeSurname = employeeSurname,
                BeginDate = beginDate,
                Birthday = birthday,
                detailSalary = detail
            };

            _salaryRepositoryMock.Setup(a => 
                a.ExistEmployeeAsync(createSalaryCommand.EmployeeName, createSalaryCommand.EmployeeSurname))
            .Returns(Task.FromResult(false));

            _salaryRepositoryMock.Setup(a =>
                a.GetSalaryByEmployeeCodeAsync(createSalaryCommand.EmployeeCode))
            .Returns(Task.FromResult(new List<Entities.Salary>()));

            // Act
            var validationResults = _createSalaryCommandValidator.Validate(createSalaryCommand);

            // Assert
            validationResults.IsValid.Should().Be(valid);
        }
    }
}
