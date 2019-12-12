using System;
using System.Collections.Generic;
using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.Services
{
    public class SanPhamService : ISanPhamService
    {
        private readonly ISanPhamRepository sanphamRepository;
        private readonly IMapper iMapper;

        public SanPhamService(ISanPhamRepository sanphamRepository, IMapper mapper)
        {
            this.sanphamRepository = sanphamRepository;
            this.iMapper = mapper;
        }
        public void Create(SanPhamDTO sanpham)
        {
            sanphamRepository.Create(iMapper.Map<SanPhamDTO, SanPham>(sanpham));
        }

        public ICollection<ChiTietHoaDonDTO> GetChiTietHoaDons(int? Id)
        {
            throw new NotImplementedException();
        }

        public SanPhamDTO GetSanPham(int? Id)
        {
            return iMapper.Map<SanPham, SanPhamDTO>(sanphamRepository.GetSanPham(Id));
        }

        public IEnumerable<SanPhamDTO> GetSanPhams()
        {
            return iMapper.Map<IEnumerable<SanPham>, IEnumerable<SanPhamDTO>>(sanphamRepository.GetSanPhams());
        }

        public ICollection<SanPhamDTO> GetSanPhams(int? Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int? Id)
        {
            sanphamRepository.Remove(Id);
        }
    }
}
