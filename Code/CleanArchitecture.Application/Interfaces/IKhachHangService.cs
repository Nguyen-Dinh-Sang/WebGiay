using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IKhachHangService
    {
        KhachHangViewModel GetNguoiDungs();

        void Create(KhachHangDTO save);
        public IEnumerable<KhachHangDTO> GetSearchTenNguoiDung(string dataTimKiem, string loaiTimKiem);
        KhachHangDTO GetNguoiDung(int? iD);

        bool CheckTaiKhoan(string taiKhoan);

        public KhachHangDTO Login(string tenDangNhap, string matKhau);
    }
}
