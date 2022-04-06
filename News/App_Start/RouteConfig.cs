using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DVCP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(null, "connector", new { controller = "File", action = "Index" });
            routes.MapRoute(
                name: "Baiviet",
                url: "bai-viet/{title}",
                defaults: new { controller = "Home", action = "ViewPost", title = UrlParameter.Optional }
            );
            //theo tag
            routes.MapRoute(
                name: "Category",
                url: "danh-muc/{title}-{id}",
                defaults: new { controller = "Home", action = "Category", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Category2",
                url: "danh-muc/",
                defaults: new { controller = "Home", action = "Category"}
            );
            routes.MapRoute(
                name: "Timkiem",
                url: "tim-kiem/",
                defaults: new { controller = "Home", action = "Search"}
            );
            routes.MapRoute(
                name: "games",
                url: "games/{title}-{Games}",
                defaults: new { controller = "Home", action = "Games", Games = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "games2",
                url: "games/",
                defaults: new { controller = "Home", action = "Games" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
