using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
    public class Khach
    {
        [Key]
        [MaxLength(50)]
        public string MaKhach { get; set; }
        [MaxLength(100)]
        public string TenKhach { get; set; }
        [MaxLength(200)]
        public string DiaChi { get; set; }
        [MaxLength(20)]
        public string DienThoai { get; set; }

        public ICollection<HoaDonBan> HoaDonBans { get; set; }
    }
}