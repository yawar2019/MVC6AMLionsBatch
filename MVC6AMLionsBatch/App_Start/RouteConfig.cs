using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC6AMLionsBatch
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();


            routes.MapRoute(
               name: "Default1",
               url: "Toy/Car",
               defaults: new { controller = "student", action = "GetView", id = UrlParameter.Optional }
           );


            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Student", action = "GetView", id = UrlParameter.Optional }
           );
        }
    }
}
