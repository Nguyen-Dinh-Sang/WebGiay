using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDon = new HashSet<HoaDon>();
        }

        public int Id { get; set; }
        public string TenKhachHang { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public int? VaiTro { get; set; }

        public virtual ICollection<HoaDon> HoaDon { get; set; }
    }
}
