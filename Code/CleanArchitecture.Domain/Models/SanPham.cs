using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietHoaDon = new HashSet<ChiTietHoaDon>();
        }

        public int Id { get; set; }
        public string TenLoai { get; set; }
        public string TenSanPham { get; set; }
        public int? Size { get; set; }
        public int? Gia { get; set; }
        public string Hinh { get; set; }
        public int? SoLuong { get; set; }

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; }
    }
}
