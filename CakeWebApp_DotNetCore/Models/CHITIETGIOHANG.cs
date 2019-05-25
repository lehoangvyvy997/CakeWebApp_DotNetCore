using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CakeWebApp_DotNetCore.Models
{
    
    public class CHITIETGIOHANG
    {
        
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSanPham { get; set; }

        
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaGioHang { get; set; }

        
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoLuongSP { get; set; }

        
        [Column(Order = 3)]
        [StringLength(12)]
        public string ThanhTien { get; set; }

        
        public GIOHANG GIOHANG { get; set; }

        
        public SANPHAM SANPHAM { get; set; }

    }
}
