using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
    public class LoaiHang
    {
        [Key]
        [MaxLength(50)]
        public string MaLoai { get; set; }
        [MaxLength(100)]
        public string TenLoai { get; set; }
        [MaxLength(200)]
        public string MoTa { get; set; }

        public ICollection<Hang> Hangs { get; set; }
    }
}