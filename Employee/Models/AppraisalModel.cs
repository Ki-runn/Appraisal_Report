using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{
    public class AppraisalModel
    {
        [Key]
        public int ID { get; set; }
        public int MID { get; set; }
        public int EmpId { get; set; }
        public string Obj1 { get; set; }
 

        public string E_Comment1 { get; set; }
   

        public string M_Comment1 { get; set; }
        

        public int Rating1 { get; set; }
      
        public string TechCompetency { get; set; }

        public string BehaviouralCompetency { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        


    }
}
