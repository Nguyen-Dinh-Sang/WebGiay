using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Data.Context;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Data.Repository
{
    public class SanPhamRepository : ISanPhamRepository
    {
        private WebEnglishDBContext webEnglishDBContext;

        public SanPhamRepository(WebEnglishDBContext webEnglishDBContext)
        {
            this.webEnglishDBContext = webEnglishDBContext;
        }
        public void Create(SanPham sanpham)
        {
            if (sanpham.Id == 0)
            {
                webEnglishDBContext.SanPham.Add(sanpham);
                webEnglishDBContext.SaveChanges();
            }
            else
            {
                SanPham findResults = webEnglishDBContext.SanPham.Find(sanpham.Id);
                findResults.TenLoai = sanpham.TenLoai;
                findResults.TenSanPham = sanpham.TenSanPham;
                findResults.Size = sanpham.Size;
                findResults.Gia = sanpham.Gia;
                findResults.Hinh = sanpham.Hinh;
                findResults.SoLuong = sanpham.SoLuong;
                webEnglishDBContext.SaveChanges();
            }
        }

        public ICollection<ChiTietHoaDon> GetChiTietHoaDons(int? Id)
        {
            throw new NotImplementedException();
        }

        public SanPham GetSanPham(int? Id)
        {
            SanPham findResults = webEnglishDBContext.SanPham.Find(Id);
            return findResults;
        }

        public IEnumerable<SanPham> GetSanPhams()
        {
            return webEnglishDBContext.SanPham;
        }

        public void Remove(int? Id)
        {
            SanPham findResults = webEnglishDBContext.SanPham.Find(Id);
            webEnglishDBContext.SanPham.Remove(findResults);
            webEnglishDBContext.SaveChanges();
        }
    }
}
