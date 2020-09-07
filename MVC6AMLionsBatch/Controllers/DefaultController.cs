using MVC6AMLionsBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC6AMLionsBatch.MyFilter;
namespace MVC6AMLionsBatch.Controllers
{

    public class DefaultController : Controller
    {
        // GET: Default


        [CustomFilter]
        public ActionResult Index()
        {
            ViewBag.Player = "Virat kohli";
            return View();
        }

        public ActionResult Index1(int? eid)
        {

            return Content(eid.ToString());
        }

        public ActionResult Index2(List<Employee> listobj)
        {
            var t = listobj.FirstOrDefault();
            return Content(t.EmpId.ToString());
        }

        public ActionResult ExampleViewData()
        {
            List<string> obj = new List<string>();
            obj.Add("pratiusha");
            obj.Add("deepti");
            obj.Add("Nagini");
            obj.Add("Anusha");
            //ViewData["Student"] = obj;
            // ViewBag.students = obj;
            TempData["Students"] = obj;
           // return View();
            return RedirectToAction("ExampleViewData2");

        }
        public ActionResult ExampleViewData2()
        {
            //var students = ViewData["Student"];//null
            //var students = ViewBag.students;//null
            //var students =TempData["Students"];//null
            //TempData.Keep();//for all tempdata
            var students = TempData.Peek("Students");//for specific tempdata
            ViewBag.Students = students;

            return View();
        }


    }
}