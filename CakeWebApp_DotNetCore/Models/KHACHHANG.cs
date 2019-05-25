using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CakeWebApp_DotNetCore.Models
{
    public class KHACHHANG
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public KHACHHANG()
        //{
        //    GIAODICHes = new HashSet<GIAODICH>();
        //}

        [Key]
        public int MaKhachHang { get; set; }

        [Required]
        [StringLength(50)]
        public string TenKhachhang { get; set; }

        [Required]
        [StringLength(15)]
        public string SoDienThoai { get; set; }

        [Required]
        [StringLength(200)]
        public string DiaChi { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public ICollection<GIAODICH> GIAODICHes { get; set; }
    }
}
