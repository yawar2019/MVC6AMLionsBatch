using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bundleMinified.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult getCalculated()
        {
            ServiceReference1.MyServiceSoapClient clientobj = new ServiceReference1.MyServiceSoapClient();
           var result= clientobj.Add(12,18);
            ServiceReference2.MyWcfServiceClient clientobj1 = new ServiceReference2.MyWcfServiceClient();
            var result2 = clientobj.Add(12, 18);
            var result1 = clientobj1.Addition(23, 34);
            return Content(result2.ToString()+ result2.ToString());
        }
    }
}