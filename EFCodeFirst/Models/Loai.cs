using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirst.Models
{
    [Table("Loai")]
    public class Loai
    {
        [Key]
        public int MaLoai { get; set; } 
        [Required(ErrorMessage ="Chưa nhập tên hàng hóa")]
        [MaxLength(50, ErrorMessage ="Tối đa 50 kí tự")]
        public string TenLoai { get; set; }
        [MaxLength(200, ErrorMessage ="Tối đa 200 kí tự")]
        public string MoTa { get; set; }
        public string Hinh { get; set; }

    }
}
