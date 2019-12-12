using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.Services
{
    public class KhachHangService : IKhachHangService
    {

        private readonly IKhachHangRopository khachHangRepository;
        private readonly IMapper iMapper;

        public KhachHangService(IKhachHangRopository khachHangRepository, IMapper iMapper)
        {
            this.khachHangRepository = khachHangRepository;
            this.iMapper = iMapper;
        }

        public bool CheckTaiKhoan(string taiKhoan)
        {
            return khachHangRepository.CheckTaiKhoan(taiKhoan);
        }

        public void Create(KhachHangDTO save)
        {
            var nguoiDung = iMapper.Map<KhachHangDTO, KhachHang>(save);
            khachHangRepository.Add(nguoiDung);
        }

        public KhachHangDTO GetNguoiDung(int? iD)
        {
            throw new NotImplementedException();
        }

        public KhachHangViewModel GetNguoiDungs()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KhachHangDTO> GetSearchTenNguoiDung(string dataTimKiem, string loaiTimKiem)
        {
            throw new NotImplementedException();
        }

        public KhachHangDTO Login(string tenDangNhap, string matKhau)
        {
            return iMapper.Map<KhachHang, KhachHangDTO>(khachHangRepository.Login(tenDangNhap, matKhau));
        }
    }
}
