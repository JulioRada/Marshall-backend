using Marshall.Application.Division;
using Marshall.Application.Office;
using Marshall.Domain.Interfaces.Repositories;
using Marshall.Infrastructure.Context;
using Marshall.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marshall.IoC
{
    public static class MarshallModule
    {
        public static void Register(this IServiceCollection services)
        {
            // Domain
            services.AddScoped<IOfficeRepository, OfficeRepository>();
            services.AddScoped<IDivisionRepository, DivisionRepository>();
            services.AddScoped<IPositionRepository, PositionRepository>();
            
            // Queries
            services.AddScoped<IOfficeQueries, OfficeQueries>();
            services.AddScoped<IDivisionQueries, DivisionQueries>();
        }
        public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MarshallContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
