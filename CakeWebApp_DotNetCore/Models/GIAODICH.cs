using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CakeWebApp_DotNetCore.Models
{
    public class GIAODICH
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public GIAODICH()
        //{
        //    DONHANGs = new HashSet<DONHANG>();
        //}

        [Key]
        public int MaGiaoDich { get; set; }

        public int MaGioHang { get; set; }

        public int? MaKhachHang { get; set; }

        public int? MaThanhVien { get; set; }

        [Required]
        [StringLength(10)]
        public string TinhTrang { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        public DateTime ThoiDiemGiaoDich { get; set; }

        [Required]
        [StringLength(12)]
        public string TongTien { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public ICollection<DONHANG> DONHANGs { get; set; }

        [ForeignKey("MaKhachHang")]
        public KHACHHANG KHACHHANG { get; set; }

        [ForeignKey("MaThanhVien")]
        public THANHVIEN THANHVIEN { get; set; }

        [ForeignKey("MaGioHang")]
        public GIOHANG GIOHANG { get; set; }
    }
}
