using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ArtistDatabase
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Artists", action = "Index", id = UrlParameter.Optional }
            );

            //routes.MapRoute(
            //    name: "Gallery",
            //    url: "Artists/Gallery/{id}",
            //    defaults: new { controller = "Artists", action = "Gallery", id = "1" }
            //);
        }
    }
}
