using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marshall.Application.Cors
{
    public static class Cors
    {
        public static void AddAppCors(this IServiceCollection services)
        {
            services.AddCors();
        }
        public static void UseAppCors(this IApplicationBuilder app)
        {
            app.UseCors(builder => builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .SetIsOriginAllowed((host) => true)
                .AllowCredentials()
            );
        }
    }
}
