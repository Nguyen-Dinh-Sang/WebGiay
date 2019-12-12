using System;
using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CleanArchitecture.Data.Context
{
    public partial class WebEnglishDBContext : DbContext
    {
        public WebEnglishDBContext()
        {
        }

        public WebEnglishDBContext(DbContextOptions<WebEnglishDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=WebDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHoaDon>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdhoaDon).HasColumnName("IDHoaDon");

                entity.Property(e => e.IdsanPham).HasColumnName("IDSanPham");

                entity.Property(e => e.TenKhachHang).HasMaxLength(100);

                entity.HasOne(d => d.IdhoaDonNavigation)
                    .WithMany(p => p.ChiTietHoaDon)
                    .HasForeignKey(d => d.IdhoaDon)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("HoaDon_ChiTietHoaDon");

                entity.HasOne(d => d.IdsanPhamNavigation)
                    .WithMany(p => p.ChiTietHoaDon)
                    .HasForeignKey(d => d.IdsanPham)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SanPham_ChiTietHoaDon");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdkhachHang).HasColumnName("IDKhachHang");

                entity.Property(e => e.Ngay)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdkhachHangNavigation)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.IdkhachHang)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("KhachHang_HoaDon");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaiKhoan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenKhachHang).HasMaxLength(100);

                entity.Property(e => e.VaiTro).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Hinh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenLoai)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenSanPham).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
