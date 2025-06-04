using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
    public class NhaCungCap
    {
        [Key]
        [MaxLength(50)]
        public string MaNCC { get; set; }
        [MaxLength(100)]
        public string TenNCC { get; set; }  
        [MaxLength(200)]
        public string DiaChi { get; set; }
        [MaxLength(20)]
        public string DienThoai { get; set; }

        public ICollection<Hang> Hangs { get; set; }
        public ICollection<HoaDonNhap> HoaDonNhaps { get; set; }
    }
}