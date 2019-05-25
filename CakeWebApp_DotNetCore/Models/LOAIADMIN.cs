using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CakeWebApp_DotNetCore.Models
{
    public class LOAIADMIN
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public LOAIADMIN()
        //{
        //    TAIKHOANADMINs = new HashSet<TAIKHOANADMIN>();
        //}

        [Key]
        public int MaLoaiAdmin { get; set; }

        [Required]
        [StringLength(100)]
        public string TenLoaiAdmin { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public ICollection<TAIKHOANADMIN> TAIKHOANADMINs { get; set; }
    }
}
