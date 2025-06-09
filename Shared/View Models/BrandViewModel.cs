using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.View_Models
{
    public class BrandViewModel
    {
        [Required]
        [MaxLength(50)]
        [Display(Name = "Mã thương hiệu")]
        public string MaThuongHieu { get; set; }

        [MaxLength(100)]
        [Display(Name = "Tên thương hiệu")]
        public string TenThuongHieu { get; set; }

        [MaxLength(100)]
        [Display(Name = "Quốc gia")]
        public string Nuoc { get; set; }

        [MaxLength(100)]
        [Display(Name = "Website")]
        public string Website { get; set; }

        [MaxLength(200)]
        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }
    }
}
