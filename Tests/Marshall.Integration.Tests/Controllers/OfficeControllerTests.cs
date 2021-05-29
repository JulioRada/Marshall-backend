using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net;
using FluentAssertions;
using System.Linq;
using Marshall.Core.Commands;
using Marshall.Domain.DTO;
using Marshall.Domain.Interfaces.Repositories;
using Marshall.Infrastructure.Repositories;
using Xunit;

namespace Marshall.Integration.Tests.Controllers
{
    public class OfficeControllerTests : ControllerBaseTests
    {
        private readonly string url = "api/office";
        private IOfficeRepository _officeRepository;


        public OfficeControllerTests()
        {
            _officeRepository = new OfficeRepository(GetContext());
            StartDatabase();
        }


        [Fact]
        public async void Must_Get_Same_Division_List()
        {
            //Arrange


            //Act
            var httpResponseMessage = _httpClient.GetAsync(url).Result;
            var response = await httpResponseMessage.Content.ReadAsAsync<IEnumerable<DivisionDTO>>();

            //Assert
            httpResponseMessage.StatusCode.Should().Be(HttpStatusCode.OK);
            (_officeRepository.GetAllAsync().Result).Count().Should().Be(response.Count());
        }
    }
}
