using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenVanCuong560.Models
{
 
    public class NVC0560
    {
        [Key]
        
        public string NVCID { get; set; }


        [Display(Name ="Tên")]
        public string NVCName { get; set; }

        [Display(Name ="Giới tính")]
        
        [Required(ErrorMessage = "Giới tính không được để trống")]  
        public Boolean NVCGender { get; set; }
      
    }
}