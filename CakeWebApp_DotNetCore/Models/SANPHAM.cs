using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CakeWebApp_DotNetCore.Models
{
    public class SANPHAM
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public SANPHAM()
        //{
        //    CHITIETGIOHANGs = new HashSet<CHITIETGIOHANG>();
        //}

        [Key]
        public int MaSanPham { get; set; }

        public int MaDanhMuc { get; set; }

        public int MaHinhAnh { get; set; }

        [Required]
        [StringLength(200)]
        public string TenSanPham { get; set; }

        [Required]
        [StringLength(12)]
        public string GiaBan { get; set; }

        [Required]
        [StringLength(12)]
        public string ChietKhau { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayTaoSP { get; set; }

        public int LuotXemSP { get; set; }

        public int LuotThichSP { get; set; }

        [ForeignKey("MaDanhMuc")]
        public DANHMUCSANPHAM DANHMUCSANPHAM { get; set; }

        [ForeignKey("MaHinhAnh")]
        public HINHANH HINHANH { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public ICollection<CHITIETGIOHANG> CHITIETGIOHANGs { get; set; }

        public IList<CHITIETGIOHANG> CHITIETGIOHANG { get; set; }
    }
}
