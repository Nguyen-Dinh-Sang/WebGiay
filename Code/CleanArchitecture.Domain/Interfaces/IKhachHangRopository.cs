using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IKhachHangRopository
    {
        IEnumerable<KhachHang> GetNguoiDungs();
        void Add(KhachHang nguoi);
        public ICollection<KhachHang> GetSearchTenNguoiDung(string dataTimKiem, string loaiTimKiem);
        KhachHang GetNguoiDung(int? iD);

        public bool CheckTaiKhoan(string taiKhoan);

        public KhachHang Login(string tenDangNhap, string matKhau);
    }
}
