using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ChiTietHoaDon, ChiTietHoaDonDTO>();
            CreateMap<ChiTietHoaDonDTO, ChiTietHoaDon>();

            CreateMap<HoaDon, HoaDonDTO>();
            CreateMap<HoaDonDTO, HoaDon>();

            CreateMap<KhachHang, KhachHangDTO>();
            CreateMap<KhachHangDTO, KhachHang>();

            CreateMap<SanPham, SanPhamDTO>();
            CreateMap<SanPhamDTO, SanPham>();
        }
    }
}
