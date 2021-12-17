using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenVanCuong560.Models
{
 
    public class UniversityNVC560
    {
        [Key]
        [Display(Name ="Mã Trường")]
        public string UniversityId { get; set; }

        [Display(Name ="Tên Trường")]
        public string UniversityName { get; set; }
    }
}