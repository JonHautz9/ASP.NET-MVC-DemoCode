using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HelloMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default", //some situations where we want to specify programmatically the route to be used when generating outgoing URLs
                url: "{controller}/{action}/{id}", //If the action is not supplied, by default it is Index. The ID is an optional segment.
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } //Home controller, Index method
            );
        }
    }
}
