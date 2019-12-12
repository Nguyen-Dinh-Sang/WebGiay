using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface ISanPhamRepository
    {
        IEnumerable<SanPham> GetSanPhams();

        SanPham GetSanPham(int? Id);

        void Create(SanPham sanpham);

        void Remove(int? Id);

        ICollection<ChiTietHoaDon> GetChiTietHoaDons(int? Id);
    }
}
