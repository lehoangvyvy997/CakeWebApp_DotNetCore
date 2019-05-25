using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CakeWebApp_DotNetCore.Models
{
    public class GIOHANG
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public GIOHANG()
        //{
        //    GIAODICHes = new HashSet<GIAODICH>();
        //    CHITIETGIOHANGs = new HashSet<CHITIETGIOHANG>();
        //}

        [Key]
        public int MaGioHang { get; set; }

        public int SoLuongLoaiSP { get; set; }

        [Required]
        [StringLength(12)]
        public string TongTien { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public ICollection<GIAODICH> GIAODICHes { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public ICollection<CHITIETGIOHANG> CHITIETGIOHANGs { get; set; }

        public IList<CHITIETGIOHANG> CHITIETGIOHANG { get; set; }
    }
}
