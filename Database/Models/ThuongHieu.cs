using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
    public class ThuongHieu
    {
        [Key]
        [MaxLength(50)]
        public string MaThuongHieu { get; set; }
        [MaxLength(100)]
        public string TenThuongHieu { get; set; }
        [MaxLength(100)]
        public string Nuoc { get; set; }
        [MaxLength(100)]
        public string Website { get; set; }
        [MaxLength(200)]
        public string MoTa { get; set; }

        public ICollection<Hang> Hangs { get; set; }
    }
}