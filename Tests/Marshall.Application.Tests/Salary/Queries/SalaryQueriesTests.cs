using Marshall.Application.Salary;
using Marshall.Domain.Interfaces.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Marshall.Application.Tests.Salary.Queries
{
    public class SalaryQueriesTests
    {
        private readonly SalaryQueries  _salaryQueries;
        private readonly Mock<ISalaryRepository> _salaryRepository;

        public SalaryQueriesTests()
        {
            _salaryRepository = new Mock<ISalaryRepository>();
            _salaryQueries =
                new SalaryQueries(_salaryRepository.Object);
        }

        [Fact]
        public void Should_Get_Salary_By_Employee_Code()
        {
            //Arrange
            string employeeCode = "123";
            int records = 3;

            //Act
            var result = _salaryQueries.GetSalaryByEmployeeCodeAsync(employeeCode, records);

            //Assert
            _salaryRepository.Verify(r => r.GetSalaryByEmployeeCodeAsync(It.IsAny<string>(), It.IsAny<int>()), Times.Once);
        }
    }
}
