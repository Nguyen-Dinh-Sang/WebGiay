using CleanArchitecture.Application.ViewModels;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Interfaces
{
    public interface ISanPhamService
    {
        
            IEnumerable<SanPhamDTO> GetSanPhams();

            SanPhamDTO GetSanPham(int? Id);

            void Create(SanPhamDTO sanPham);

            void Remove(int? Id);

            ICollection<SanPhamDTO> GetSanPhams(int? Id);

            ICollection<ChiTietHoaDonDTO> GetChiTietHoaDons(int? Id);
        
    }
}
