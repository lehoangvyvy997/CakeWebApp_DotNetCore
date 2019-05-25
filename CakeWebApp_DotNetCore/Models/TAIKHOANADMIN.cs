using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CakeWebApp_DotNetCore.Models
{
    public class TAIKHOANADMIN
    {
        [Key]
        public int MaTaiKhoan { get; set; }

        public int MaLoaiAdmin { get; set; }

        public int? MaNhanVien { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string PasswordTK { get; set; }

        [ForeignKey("MaLoaiAdmin")]
        public LOAIADMIN LOAIADMIN { get; set; }

        [ForeignKey("MaNhanVien")]
        public NHANVIEN NHANVIEN { get; set; }
    }
}
