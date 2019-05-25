using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CakeWebApp_DotNetCore.Models
{
    public class CHUCVU
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public CHUCVU()
        //{
        //    NHANVIENs = new HashSet<NHANVIEN>();
        //}

        [Key]
        public int MaChucVu { get; set; }

        [Required]
        [StringLength(100)]
        public string TenChucVu { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public ICollection<NHANVIEN> NHANVIENs { get; set; }
    }
}
