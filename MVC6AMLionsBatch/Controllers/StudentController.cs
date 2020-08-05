using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC6AMLionsBatch.Models;
namespace MVC6AMLionsBatch.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public string Index()
        {
            return "Hello World";
        }
        
        public ActionResult GetView() {

            return View();
        }
       [Route("Heroes/Superman")]
       [Route("Heroes/Spiderman")]
        [Route("Heroes/Heman")]
       

        public ActionResult GetViewTest()
        {

            return View();
        }

        public ActionResult GetData() {

            ViewBag.studentName = "Ankita";
            return View("TestStudent");
        }
        public ActionResult GetModelData()
        {
            Employee obj = new Employee();
            obj.EmpId = 1211;
            obj.EmpName = "Kalyan";
            obj.EmpSalary = 89000;

            ViewBag.EmployeeName = obj;
            return View();
        }
        public ActionResult GetMultipleModelData()
        {

            List<Employee> listobj = new List<Employee>();
            Employee obj = new Employee();
            obj.EmpId = 1211;
            obj.EmpName = "Kalyan";
            obj.EmpSalary = 89000;

            Employee obj1 = new Employee();
            obj1.EmpId = 1212;
            obj1.EmpName = "Ankita";
            obj1.EmpSalary = 79000;

            Employee obj2 = new Employee();
            obj2.EmpId = 1213;
            obj2.EmpName = "vritika";
            obj2.EmpSalary = 7000;


            listobj.Add(obj);
            listobj.Add(obj1);
            listobj.Add(obj2);

            ViewBag.EmployeeName = listobj;
            return View();
        }
    }
}