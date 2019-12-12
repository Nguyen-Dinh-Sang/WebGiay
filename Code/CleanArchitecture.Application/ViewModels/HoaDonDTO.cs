using System;
using System.Collections.Generic;

namespace CleanArchitecture.Application.ViewModels
{
    public partial class HoaDonDTO
    {
        public HoaDonDTO()
        {
            ChiTietHoaDon = new HashSet<ChiTietHoaDonDTO>();
        }

        public int Id { get; set; }
        public int? IdkhachHang { get; set; }
        public string Ngay { get; set; }
        public int? TongTien { get; set; }

        public virtual KhachHangDTO IdkhachHangNavigation { get; set; }
        public virtual ICollection<ChiTietHoaDonDTO> ChiTietHoaDon { get; set; }
    }
}
