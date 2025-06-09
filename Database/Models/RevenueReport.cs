using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class RevenueReport
    {
        [Key]
        public string Id { get; set; } 
        public string MaHoaDon { get; set; }
        public DateTime NgayBan { get; set; }
        public string TenNhanVien { get; set; }
        public string TenKhach { get; set; }
        public string TenHang { get; set; }
        public string TenLoai { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
        public decimal TongTien { get; set; }
    }

}
