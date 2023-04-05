using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{
    public class AppraisalStatus
    {
        [Key]
        public int AppraisalId { get; set; }

        public string Status { get; set; }
       
        public int EID { get; set; }

        public int MID { get; set; }


    }
}
