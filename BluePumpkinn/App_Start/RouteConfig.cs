﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BluePumpkinn
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
                name: "Events",
                url: "Home/Events/{id}",
                defaults: new { controller = "Home", action = "EventForm", id = UrlParameter.Optional}
            );

            routes.MapRoute(
                name: "Event",
                url: "Event/{action}/{id}",
                defaults: new { controller = "Event", action = "Event1", id = UrlParameter.Optional }
            );
        }

    }
}
