﻿namespace InformationalApp
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "User profiles",
               url: "CustomRoute/{username}",
               defaults: new
               {
                   controller = "CustomRoute",
                   action = "ByUsername",
                   id = UrlParameter.Optional
               });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}
