using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeWebApp_DotNetCore.Models
{
    public class ProjectDBContext :DbContext
    {
        public ProjectDBContext(DbContextOptions<ProjectDBContext>options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHITIETGIOHANG>().HasKey(sc => new { sc.MaGioHang, sc.MaSanPham });
        }
        public DbSet<CHUCVU> CHUCVUs { get; set; }
        public DbSet<DANHMUCSANPHAM> DANHMUCSANPHAMs { get; set; }
        public DbSet<DONHANG> DONHANGs { get; set; }
        public DbSet<GIAODICH> GIAODICHes { get; set; }
        public DbSet<GIOHANG> GIOHANGs { get; set; }
        public DbSet<HINHANH> HINHANHs { get; set; }
        public DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public DbSet<LOAIADMIN> LOAIADMINs { get; set; }
        public DbSet<NHANVIEN> NHANVIENs { get; set; }
        public DbSet<SANPHAM> SANPHAMs { get; set; }
        public DbSet<TAIKHOANADMIN> TAIKHOANADMINs { get; set; }
        public DbSet<THANHVIEN> THANHVIENs { get; set; }
        public DbSet<CHITIETGIOHANG> CHITIETGIOHANGs { get; set; }
        
    }
}
