using System.ComponentModel.DataAnnotations;

namespace HQD_2324.Models
{
    public class Person
    {
        [Key]
        [Display(Name ="Mã ID")]
        public int ID {get; set;}
        [Display(Name = "Tên ")]
        [MaxLength(50)]
        public string HoTen { get ;set;}
         public string Diachi { get ;set;}
      
    }
}
