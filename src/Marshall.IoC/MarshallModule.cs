using Marshall.Application.Division;
using Marshall.Application.Office;
using Marshall.Application.Position;
using Marshall.Domain.Interfaces.Repositories;
using Marshall.Infrastructure.Context;
using Marshall.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Marshall.Application.Cors;
using Marshall.Application.Salary;
using Marshall.Core.Interfaces;
using Marshall.Domain.Commands.Salary;
using FluentValidation;
using Marshall.Domain.Commands.Salary.Validators;

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
            services.AddScoped<ISalaryRepository, SalaryRepository>();

            // Validators
            services.AddScoped<IValidator<CreateSalaryCommand>, CreateSalaryCommandValidator>();

            // CommandHandlers
            services.AddScoped<ICommandHandler<CreateSalaryCommand>, CreateSalaryCommandHandler>();

            // Queries
            services.AddScoped<IOfficeQueries, OfficeQueries>();
            services.AddScoped<IDivisionQueries, DivisionQueries>();
            services.AddScoped<IPositionQueries, PositionQueries>();
            services.AddScoped<ISalaryQueries, SalaryQueries>();

            // Config App
            services.AddAppCors();
        }
        public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MarshallContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
        public static void AddControllersWithNewtonsoft(this IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson();
        }
        public static void Register(this IApplicationBuilder app)
        {
            // Cors
            app.UseAppCors();
        }
    }
}
