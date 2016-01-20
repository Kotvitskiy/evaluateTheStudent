using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TheBest.Extensions.Web;

namespace TheBest
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.Route("Index", "Students", "about", "_about");

            routes.Route("List", "Students", "list", "_list");

            routes.Route("Data", "Students", "students-data", "_studentsData");

            routes.Route("Rate", "Students", "rate", "_rate");

            routes.Route("Index", "Students", "", "_default");

            routes.Route("Details", "Students", "details", "_details");
        }
    }
}
