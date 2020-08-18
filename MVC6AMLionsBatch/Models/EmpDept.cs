using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC6AMLionsBatch.Models
{
    public class EmpDept
    {
        public Employee  Emp { get; set; }
        public Department Dep { get; set; }
    }
}