using Marshall.Domain.Interfaces.Repositories;
using Marshall.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Net.Http;
using System.Net;
using FluentAssertions;
using System.Linq;
using Marshall.Domain.DTO;

namespace Marshall.Integration.Tests.Controllers
{
    public class DivisionControllerTests: ControllerBaseTests
    {
        private readonly string url = "api/division";
        private IDivisionRepository _divisionRepository;


        public DivisionControllerTests()
        {
            _divisionRepository = new DivisionRepository(GetContext());
            StartDatabase();
        }


        [Fact(Skip = "Using Sonarqube")]
        public async void Must_Get_Same_Division_List()
        {
            //Arrange
            IEnumerable<DivisionDTO> response = null;

            //Act
            var httpResponseMessage = _httpClient.GetAsync(url).Result;

            var exception = await Record.ExceptionAsync(async () =>  await httpResponseMessage.Content.ReadAsAsync<IEnumerable<DivisionDTO>>());
            
            
            //Assert

            httpResponseMessage.StatusCode.Should().Be(HttpStatusCode.OK);
            (_divisionRepository.GetAllAsync().Result).Count().Should().Be(response.Count());
        }
    }
}
