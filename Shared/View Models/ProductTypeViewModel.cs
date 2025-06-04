using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.View_Models
{
    public class ProductTypeViewModel
    {
        [Required]
        [MaxLength(50)]
        [Display(Name = "Mã loại")]
        public string MaLoai { get; set; }

        [MaxLength(100)]
        [Display(Name = "Tên loại")]
        public string TenLoai { get; set; }

        [MaxLength(200)]
        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }
    }
}
