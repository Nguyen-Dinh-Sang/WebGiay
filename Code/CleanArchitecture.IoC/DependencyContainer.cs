using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Mapping;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Data.Context;
using CleanArchitecture.Data.Repository;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
        
            services.AddScoped<WebEnglishDBContext>();

            services.AddAutoMapper(typeof(MappingProfile));

            
            services.AddScoped<IHoaDonService, HoaDonService>();
            services.AddScoped<IHoaDonRepository, HoaDonRepository>();


            services.AddScoped<IChiTietHoaDonService, ChiTietHoaDonService>();
            services.AddScoped<IChiTietHoaDonRepository, ChiTietHoaDonRepository>();


            services.AddScoped<ISanPhamService, SanPhamService>();
            services.AddScoped<ISanPhamRepository, SanPhamRepository>();


            services.AddScoped<IKhachHangService, KhachHangService>();
            services.AddScoped<IKhachHangRopository, KhachHangRepository>();
        }
    }
}
