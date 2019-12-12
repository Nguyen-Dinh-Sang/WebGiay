using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models
{
    public partial class ChiTietHoaDon
    {
        public int Id { get; set; }
        public int? IdhoaDon { get; set; }
        public int? IdsanPham { get; set; }
        public string TenKhachHang { get; set; }
        public int? ThanhTien { get; set; }

        public virtual HoaDon IdhoaDonNavigation { get; set; }
        public virtual SanPham IdsanPhamNavigation { get; set; }
    }
}
