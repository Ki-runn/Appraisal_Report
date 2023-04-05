using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{
    public class Emp
    {
        [Key]
        public int  ID { get; set; }
        [Required]
        public int EmpId { get; set; }
        [Required]
        public string  Name { get; set; }
        [Required]
        public string Designation { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }
        
        [StringLength(20,MinimumLength =5,ErrorMessage ="Type a Stronger password")]
        public string Pass { get; set; }
        [Required]
       // [StringLength(12,MinimumLength =10,ErrorMessage ="Mobile number not valid")]
        public  string  Phone { get; set; }
        [Required]
        public int MID { get; set; }
        
    }
}
