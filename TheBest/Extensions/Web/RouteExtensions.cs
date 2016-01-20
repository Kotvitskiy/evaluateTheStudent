using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TheBest.Extensions.Web
{
    public static class RouteExtensions
    {
        public static Route Route(this RouteCollection collection, string action, string controller, string url, string routeName)
        {
            return collection.MapRoute(
                routeName,
                url,
                new { controller = controller, action = action },
                new[] { "TheBest.Controllers" });
        }

        public static Route AdminRoute(this AreaRegistrationContext context, string action, string controller, string url, string routeName)
        {
            return context.MapRoute(
                routeName,
                url,
                new { controller = controller, action = action },
                new[] { "TheBest.Areas.Admin.Controllers" });
        }
    }
}