using System;
using System.Collections.Generic;

namespace CleanArchitecture.Application.ViewModels
{
    public partial class ChiTietHoaDonDTO
    {
        public int Id { get; set; }
        public int? IdhoaDon { get; set; }
        public int? IdsanPham { get; set; }
        public string TenKhachHang { get; set; }
        public int? ThanhTien { get; set; }

        public virtual HoaDonDTO IdhoaDonNavigation { get; set; }
        public virtual SanPhamDTO IdsanPhamNavigation { get; set; }
    }
}
