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

        public ActionResult GetView()
        {

            return View();
        }
        [Route("Heroes/Superman")]
        [Route("Heroes/Spiderman")]
        [Route("Heroes/Heman")]


        public ActionResult GetViewTest()
        {

            return View();
        }

        public ActionResult GetData()
        {

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

        public ActionResult GetSingleEmpData()
        {
            Employee obj = new Employee();
            obj.EmpId = 1211;
            obj.EmpName = "Kalyan";
            obj.EmpSalary = 89000;




            //object model = obj;
            return View(obj);
        }

        public ActionResult GetMulEmpData()
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

            //object model = obj;
            return View(listobj);
        }

        public ActionResult GetMulModel()
        {
            Employee obj = new Employee();
            obj.EmpId = 1211;
            obj.EmpName = "Kalyan";
            obj.EmpSalary = 89000;

            Department deptObj = new Models.Department();
            deptObj.DeptId = 1;
            deptObj.DeptName = "Account";

            EmpDept EmpDeptobj = new EmpDept();
            EmpDeptobj.Emp = obj;
            EmpDeptobj.Dep = deptObj;
            //object model = obj;

            return View(EmpDeptobj);
        }

        ///ActionResult Classess
        ///
        public ViewResult GetViewTest2()
        {
            return View("GetData");
        }

        public ViewResult GetViewTest2AnotherFolder()
        {
            Employee obj = new Employee();
            obj.EmpId = 1211;
            obj.EmpName = "Kalyan";
            obj.EmpSalary = 89000;

            return View("~/Views/Default/index.cshtml", obj);
        }

        public RedirectResult GetRedirectToGoogle()
        {
            return Redirect("http://www.google.com");
        }
        public RedirectResult GetRedirectToMethod()
        {
            return Redirect("~/Student/GetViewTest2AnotherFolder");
        }

        public RedirectToRouteResult getRedirectRouteEx()
        {
            return RedirectToRoute("Default1");

        }

        //Example for Same Controller ActionMethod Redirecting
        public RedirectToRouteResult getRedirectToAction() {
            return RedirectToAction("getRedirectRouteEx");
        }

        //Example for Different Controller ActionMethod Redirecting
        public RedirectToRouteResult getDifferentRedirectToAction(int ? id)
        {
            return RedirectToAction("Index1", "Default",new { eid= id });
        }
        //Pass Model as redierect Method 
        public RedirectToRouteResult getDifferentRedirectToActionEx2()
        {
            //Employee obj = new Employee();
            //obj.EmpId = 1211;
            //obj.EmpName = "Kalyan";
            //obj.EmpSalary = 89000;

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

            return RedirectToAction("Index2", "Default", listobj);
        }

        public JsonResult GetjsonData()
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

            return Json(listobj, JsonRequestBehavior.AllowGet);

        }

        public FileResult getFile()
        {
            return File("~/Web.config", "text/plain");
        }


        public FileResult getOrignalFileFormat()
        {
            return File("~/Web.config", "application/xml");
        }

        public FileResult getOrignalFileFormat2()
        {
            return File("~/Web.config", "application/pdf");
        }
        public FileResult getDownloadFile()
        {
            return File("~/Web.config", "application/xml","Web.config");
        }

        public ContentResult GetContent(int? id)
        {
            if (id == 1)
            {
                return Content("Hello World");
            }
            else if (id == 2)
            {
                return Content("<p style=color:red>Hello World</p>");
            }
            else
            {
                return Content("<script>alert('Hey How  R u Today')</script>");
            }
        }

        public ActionResult TestStudent() {
            return View();
        }
    }
}