﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBaseFirstApproach.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TestEmployeeEntities : DbContext
    {
        public TestEmployeeEntities()
            : base("name=TestEmployeeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<sp_employee_Result> sp_employee()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_employee_Result>("sp_employee");
        }
    
        public virtual ObjectResult<spr_getEmployeeDetails_Result> spr_getEmployeeDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spr_getEmployeeDetails_Result>("spr_getEmployeeDetails");
        }
    
        public virtual int sp_NewemployeeList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_NewemployeeList");
        }
    
        public virtual int spr_insertEmployee(string empName, Nullable<int> empSalary)
        {
            var empNameParameter = empName != null ?
                new ObjectParameter("EmpName", empName) :
                new ObjectParameter("EmpName", typeof(string));
    
            var empSalaryParameter = empSalary.HasValue ?
                new ObjectParameter("EmpSalary", empSalary) :
                new ObjectParameter("EmpSalary", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spr_insertEmployee", empNameParameter, empSalaryParameter);
        }
    }
}