//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.ChiTiet_DonHang_Sanpham = new HashSet<ChiTiet_DonHang_Sanpham>();
            this.Chitiet_PhieuNhapHang_SanPham = new HashSet<Chitiet_PhieuNhapHang_SanPham>();
        }
    
        public int masp { get; set; }
        public int maloaisanpham { get; set; }
        public string tensanpham { get; set; }
        public string mota { get; set; }
        public string hinhanh { get; set; }
        public Nullable<int> maquocgia { get; set; }
        public Nullable<System.DateTime> ngaycapnhat { get; set; }
        public Nullable<int> soluong { get; set; }
        public Nullable<decimal> dongia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTiet_DonHang_Sanpham> ChiTiet_DonHang_Sanpham { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitiet_PhieuNhapHang_SanPham> Chitiet_PhieuNhapHang_SanPham { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
        public virtual QuocGia QuocGia { get; set; }
    }
}