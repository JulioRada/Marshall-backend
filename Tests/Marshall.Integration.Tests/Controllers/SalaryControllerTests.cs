using Marshall.Domain.Commands.Salary;
using Marshall.Domain.Interfaces.Repositories;
using Marshall.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Net.Http;
using System.Net;
using FluentAssertions;
using Marshall.Core.Commands;
using Marshall.Domain.DTO;

namespace Marshall.Integration.Tests.Controllers
{
    public class SalaryControllerTests: ControllerBaseTests
    {
        private readonly string url = "api/salary";
        private ISalaryRepository _salaryRepository;


        public SalaryControllerTests()
        {
            _salaryRepository = new SalaryRepository(GetContext());

            StartDatabase();
            ResetDatabase();
        }

        [Fact]
        public void Should_Save_Salary()
        {
            //Arrange
            var salary = new CreateSalaryCommand { 
                IdentificationNumber = "1",
                EmployeeCode = "123",
                EmployeeName = "Jose",
                EmployeeSurname = "Perez",
                BeginDate = new DateTime(2020, 10, 5),
                Birthday = new DateTime(1990, 5, 3),
                detailSalary = new List<DetailSalaryCommand>()
                {
                    new DetailSalaryCommand()
                    {
                        Year = 2020,
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
                }
            };

            //Act
            var httpResponseMessage = _httpClient.PostAsJsonAsync(url, salary).Result;

            //Assert
            httpResponseMessage.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async void Not_Should_Save_Salary()
        {
            //Arrange
            var salary = new CreateSalaryCommand
            {
                IdentificationNumber = "1",
                EmployeeCode = "123",
                EmployeeName = "Jose",
                EmployeeSurname = "Perez",
                BeginDate = new DateTime(2020, 10, 5),
                Birthday = new DateTime(1990, 5, 3),
                detailSalary = new List<DetailSalaryCommand>()
                {
                    new DetailSalaryCommand()
                    {
                        Year = 2020,
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
                }
            };

            //Act
            var firstHttpResponseMessage = _httpClient.PostAsJsonAsync(url, salary).Result;
            firstHttpResponseMessage.StatusCode.Should().Be(HttpStatusCode.OK);

            var secondHttpResponseMessage = _httpClient.PostAsJsonAsync(url, salary).Result;
            var response = await secondHttpResponseMessage.Content.ReadAsAsync<Result>();

            secondHttpResponseMessage.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Errors.Should().HaveCountGreaterOrEqualTo(1);
        }
        [Fact]
        public async void Should_Be_Invalid_Save_Without_The_Salary_Detail()
        {
            //Arrange
            var salary = new CreateSalaryCommand
            {
                IdentificationNumber = "1",
                EmployeeCode = "123",
                EmployeeName = "Jose",
                EmployeeSurname = "Perez",
                BeginDate = new DateTime(2020, 10, 5),
                Birthday = new DateTime(1990, 5, 3),
                detailSalary = new List<DetailSalaryCommand>()
            };

            //Act
            var secondHttpResponseMessage = _httpClient.PostAsJsonAsync(url, salary).Result;
            var response = await secondHttpResponseMessage.Content.ReadAsAsync<Result>();
            
            // Assert
            secondHttpResponseMessage.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Errors.Should().HaveCountGreaterOrEqualTo(1);
        }

        [Fact]
        public async void Should_Get_Salary_By_Employee_Code()
        {
            //Arrange
            var secondHttpResponseMessage = _httpClient.GetAsync($"{url}/0/3").Result;

            //Act
            var response = await secondHttpResponseMessage.Content.ReadAsAsync<List<SalaryDTO>>();

            // Assert
            secondHttpResponseMessage.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Should().HaveCountLessOrEqualTo(0);
            response.Should().BeInAscendingOrder(x => x.Year);
        }
    }
}
