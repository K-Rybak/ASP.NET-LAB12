﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab12
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Reg",
                url: "{controller}/{action}",
                defaults: new { controller = "Registration", action = "Reg" }
            );

            routes.MapRoute(
                name: "Chat",
                url: "{controller}/{action}",
                defaults: new { controller = "Chat", action = "Index" }
            );

           
     
        }
    }
}
