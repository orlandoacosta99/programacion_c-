using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CompraloTo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //remove asp.net header
            MvcHandler.DisableMvcResponseHeader = true;

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //enable attribute routing
            routes.MapMvcAttributeRoutes();

            //set all routes to lower case
            routes.LowercaseUrls = true;

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "CheckUserNameExists",
                url: "account/checkUserNameExists"
            );
        }
    }
}
