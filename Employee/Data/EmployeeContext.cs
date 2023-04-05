using Employee.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Employee.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }

        public DbSet<Emp> EmpTable { get; set; }
        public DbSet<AppraisalStatus> Status { get; set; }
        public DbSet<AppraisalModel> AppraisalModel { get; set; }

         


    }
}
