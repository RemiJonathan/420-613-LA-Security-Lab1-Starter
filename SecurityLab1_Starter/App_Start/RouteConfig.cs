﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SecurityLab1_Starter
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Inventory",
                url: "Inventory/Index",
                defaults: new { controller = "Inventory", action = "Index"}
            );

            routes.MapRoute(
                name: "Home",
                url: "Home/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { action = "Index|Contact|About|GenError" }

            );

            routes.MapRoute(
                name: "Login",
                url: "Account/Login",
                defaults: new { controller = "Account", action = "Login" }
            );

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Home", action = "Index"}
            );

            routes.MapRoute(
               name: "Server Error",
               url: "Error/ServerError",
               defaults: new { controller = "Error", action = "ServerError" }
               );

            routes.MapRoute(
                name: "Not Found Error",
                url: "{*url}",
                defaults: new {controller = "Error", action = "NotFound"}
                );

           

        }
    }
}
