using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Motor.Models
{
    public class SanPham
    {
        public int maSanPham { get; set; }
        public int maLoai { get; set; }
        public string tenSanPham { get; set; }
        public string hinhAnh { get; set; }
        public int donGia { get; set; }
        public string mauSac { get; set; }
        public string moTa { get; set; }
    }
}