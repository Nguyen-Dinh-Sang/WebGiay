using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CleanArchitecture.Application.Mapping;
using CleanArchitecture.Data.Context;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
        
            services.AddScoped<WebEnglishDBContext>();

            services.AddAutoMapper(typeof(MappingProfile));

            // mỗi đứa một cặp
            //services.AddScoped<IChuDeService, ChuDeService>();
            //services.AddScoped<IChuDeRepository, ChuDeRepository>();

        }
    }
}
