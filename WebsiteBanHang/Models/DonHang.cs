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
    
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            this.ChiTiet_DonHang_Sanpham = new HashSet<ChiTiet_DonHang_Sanpham>();
        }
    
        public int madonhang { get; set; }
        public Nullable<int> makh { get; set; }
        public Nullable<bool> tinhtranggiaohang { get; set; }
        public Nullable<System.DateTime> ngaydathang { get; set; }
        public Nullable<System.DateTime> ngaygiaohang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTiet_DonHang_Sanpham> ChiTiet_DonHang_Sanpham { get; set; }
        public virtual KhachHang KhachHang { get; set; }
    }
}
