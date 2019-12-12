<<<<<<< HEAD
﻿using AutoMapper;
=======
﻿using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
>>>>>>> 7e10970c51f61ce0953f7486297b3406022ed8b8
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
