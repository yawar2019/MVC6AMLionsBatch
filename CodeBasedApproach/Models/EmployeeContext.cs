using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace CodeBasedApproach.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext():base("ConStr") {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}