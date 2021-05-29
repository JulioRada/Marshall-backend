using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net.Http;
using Marshall.Api;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Marshall.Infrastructure.Context;
using Microsoft.Extensions.DependencyInjection;

namespace Marshall.Integration.Tests.Controllers
{
    public class ControllerBaseTests
    {
        protected readonly HttpClient _httpClient;
        private readonly IServiceProvider _serviceProvider;
        private const string connectionString = "Server=tcp:sql-db-v8-001.database.windows.net,1433;Initial Catalog=marshall;Persist Security Info=False;User ID=sysadmin;Password=GBIDio6viTg8;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public ControllerBaseTests()
        {
            var _webApplicationFactory = new WebApplicationFactory<Startup>().WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<MarshallContext>));
                    services.Remove(descriptor);
                    services.AddDbContext<MarshallContext>(options => { options.UseSqlServer(connectionString); });
                });
            });

            _serviceProvider = _webApplicationFactory.Services;
            _httpClient = _webApplicationFactory.CreateClient();
        }

        public MarshallContext GetContext()
        {
            return _serviceProvider.CreateScope().ServiceProvider.GetRequiredService<MarshallContext>();
        }

        protected void StartDatabase()
        {
            var marshallContext = GetContext();
            marshallContext.Database.Migrate();
        }

        protected virtual void SeedData(params object[] data)
        {
            var marshallContext = GetContext();
            marshallContext.AddRange(data);
            marshallContext.SaveChanges();
        }

        protected void ResetDatabase()
        {
            var marshallContext = GetContext();
            marshallContext.Database.ExecuteSqlRaw("delete salary");
        }
    }
}
