using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CakeWebApp_DotNetCore.Models
{
    public class HINHANH
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public HINHANH()
        //{
        //    SANPHAMs = new HashSet<SANPHAM>();
        //}

        [Key]
        public int MaHinhAnh { get; set; }

        [Required]
        [StringLength(200)]
        public string Link { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public ICollection<SANPHAM> SANPHAMs { get; set; }
    }
}
