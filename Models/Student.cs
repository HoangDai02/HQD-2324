using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HQD_2324.Models;

namespace HQD_2324.Models
{
    public class Student
    {
       
        [Display(Name = "Mã sinh viên")]
        [MaxLength(20)]
         [Key]
        public string MaSinhVien { get; set; }
        [Display(Name = "Họ và tên")]
        [MaxLength(50)]
        public string HoTen { get; set;}
        [Display(Name = "Mã lớp")]
        [ForeignKey("MaLop")]
        public int? MaLop { get; set; }
        [Display(Name = "Mã lớp")]
        public LopHoc? LopHoc { get; set; }

    }
}
