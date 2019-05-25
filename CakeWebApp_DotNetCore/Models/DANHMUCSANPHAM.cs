using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CakeWebApp_DotNetCore.Models
{
    public class DANHMUCSANPHAM
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public DANHMUCSANPHAM()
        //{
        //    DANHMUCSANPHAM1 = new HashSet<DANHMUCSANPHAM>();
        //    SANPHAMs = new HashSet<SANPHAM>();
        //}

        [Key]
        public int MaDanhMuc { get; set; }

        public int? MaDanhMucCha { get; set; }

        [Required]
        [StringLength(200)]
        public string TenDanhMuc { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public ICollection<DANHMUCSANPHAM> DANHMUCSANPHAM1 { get; set; }

        [ForeignKey("MaDanhMuc")]
        public DANHMUCSANPHAM DANHMUCSANPHAM2 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public ICollection<SANPHAM> SANPHAMs { get; set; }
    }
}
