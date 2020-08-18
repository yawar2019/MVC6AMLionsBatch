using MVC6AMLionsBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC6AMLionsBatch.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
           
            return View( );
        }

        public ActionResult Index1(int ? eid)
        {

            return Content(eid.ToString());
        }

        public ActionResult Index2(List<Employee> listobj)
        {
            var t = listobj.FirstOrDefault();
            return Content(t.EmpId.ToString());
        }


    }
}