using System;
using System.Collections.Generic;

namespace CleanArchitecture.Application.ViewModels
{
    public partial class SanPhamDTO
    {
        public SanPhamDTO()
        {
            ChiTietHoaDon = new HashSet<ChiTietHoaDonDTO>();
        }

        public int Id { get; set; }
        public string TenLoai { get; set; }
        public string TenSanPham { get; set; }
        public int? Size { get; set; }
        public int? Gia { get; set; }
        public string Hinh { get; set; }
        public int? SoLuong { get; set; }

        public virtual ICollection<ChiTietHoaDonDTO> ChiTietHoaDon { get; set; }
    }
}
