using Marshall.Application.Salary;
using Marshall.Domain.Commands.Salary;
using Marshall.Domain.Commands.Salary.Validators;
using Marshall.Domain.Interfaces.Repositories;
using Marshall.Infrastructure.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Marshall.Application.Tests.Salary.CommandHandler
{
    public class CreateSalaryCommandHandlerTests
    {
        private readonly CreateSalaryCommandHandler _createSalaryCommandHandler;
        private readonly Mock<ISalaryRepository> _salaryRepository;

        public CreateSalaryCommandHandlerTests()
        {
            _salaryRepository = new Mock<ISalaryRepository>();
            var createSalaryCommandValidator =
                new CreateSalaryCommandValidator(_salaryRepository.Object);

            _createSalaryCommandHandler =
                new CreateSalaryCommandHandler(createSalaryCommandValidator, _salaryRepository.Object);
        }

        [Fact]
        public void Should_Not_Create_When_Command_Is_Invalid()
        {
            //Arrange
            var salary = new CreateSalaryCommand()
            {
                IdentificationNumber = "1",
                EmployeeCode = "123",
                EmployeeName = "Jose",
                EmployeeSurname = "Perez",
                BeginDate = new DateTime(2020, 10, 5),
                Birthday = new DateTime(1990, 5, 3),
                detailSalary = new List<DetailSalaryCommand>() { 
                    new DetailSalaryCommand()
                    {
                        Division = -1
                    }
                }
            };

            //Act
            var result = _createSalaryCommandHandler.Handle(salary);

            //Assert
            _salaryRepository.Verify(r => r.Add(It.IsAny<Domain.Entities.Salary>()), Times.Never);
        }
    }
}
