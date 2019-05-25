using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CakeWebApp_DotNetCore.Models
{
    public class DONHANG
    {
        [Key]
        public int MaDonHang { get; set; }

        public int MaGiaoDich { get; set; }

        public int? MaNhanVien { get; set; }

        [Required]
        [StringLength(20)]
        public string TinhTrangGiaohang { get; set; }

        [ForeignKey("MaNhanVien")]
        public NHANVIEN NHANVIEN { get; set; }

        [ForeignKey("MaGiaoDich")]
        public GIAODICH GIAODICH { get; set; }
    }
}
