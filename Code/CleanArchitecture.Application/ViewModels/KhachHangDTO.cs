using System;
using System.Collections.Generic;

namespace CleanArchitecture.Application.ViewModels
{
    public partial class KhachHangDTO
    {
        public KhachHangDTO()
        {
            HoaDon = new HashSet<HoaDonDTO>();
        }

        public int Id { get; set; }
        public string TenKhachHang { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public VaiTroo VaiTro { get; set; }

        public enum VaiTroo
        {
            NguoiDungThuong = 2,
            NguoiQuanTri = 1
        }

        public virtual ICollection<HoaDonDTO> HoaDon { get; set; }
    }
}
