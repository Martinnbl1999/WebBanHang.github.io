﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsiteBanHang.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBWebsiteQuanLyCuaHangSoi : DbContext
    {
        public DBWebsiteQuanLyCuaHangSoi()
            : base("name=DBWebsiteQuanLyCuaHangSoi")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTiet_DonHang_Sanpham> ChiTiet_DonHang_Sanpham { get; set; }
        public virtual DbSet<Chitiet_PhieuNhapHang_SanPham> Chitiet_PhieuNhapHang_SanPham { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhaPhanPhoi> NhaPhanPhois { get; set; }
        public virtual DbSet<PhieuNhapHang> PhieuNhapHangs { get; set; }
        public virtual DbSet<QuocGia> QuocGias { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
    }
}