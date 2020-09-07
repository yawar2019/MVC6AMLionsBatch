using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeBasedApproach.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string  EmpName { get; set; }
        public int EmpSalary { get; set; }
        public string Address { get; set; }
    }
}