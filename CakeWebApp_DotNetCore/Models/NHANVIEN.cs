using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CakeWebApp_DotNetCore.Models
{
    public class NHANVIEN
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public NHANVIEN()
        //{
        //    DONHANGs = new HashSet<DONHANG>();
        //    TAIKHOANADMINs = new HashSet<TAIKHOANADMIN>();
        //}

        [Key]
        public int MaNhanVien { get; set; }

        public int MaChucVu { get; set; }

        [Required]
        [StringLength(100)]
        public string TenNhanVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(15)]
        public string SDT { get; set; }

        [Required]
        [StringLength(200)]
        public string DiaChi { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayVaoLam { get; set; }

        [Required]
        [StringLength(12)]
        public string TienLuong { get; set; }

        [Required]
        [StringLength(12)]
        public string TienTroCap { get; set; }

        [ForeignKey("MaChucVu")]
        public CHUCVU CHUCVU { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public ICollection<DONHANG> DONHANGs { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public ICollection<TAIKHOANADMIN> TAIKHOANADMINs { get; set; }
    }
}
