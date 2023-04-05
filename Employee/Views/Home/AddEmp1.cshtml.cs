using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employee.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Employee.Views.Home
{
    public class AddEmp1Model : PageModel
    {
        public Emp Addemp { get; set; }
        public void OnGet()
        {
        }
    }
}
