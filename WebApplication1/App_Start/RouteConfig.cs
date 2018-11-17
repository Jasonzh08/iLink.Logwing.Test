using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });
            routes.IgnoreRoute("BankCertificateFile/{*pathInfo}");
            routes.IgnoreRoute("css/{*pathInfo}");
            routes.IgnoreRoute("DownloadFile/{*pathInfo}");
            routes.IgnoreRoute("editor/{*pathInfo}");
            routes.IgnoreRoute("ext-ux/{*pathInfo}");
            routes.IgnoreRoute("extjs/{*pathInfo}");
            routes.IgnoreRoute("fonts/{*pathInfo}");
            routes.IgnoreRoute("images/{*pathInfo}");
            routes.IgnoreRoute("Providers/{*pathInfo}");
            routes.IgnoreRoute("Scripts/{*pathInfo}");
            routes.IgnoreRoute("Service/{*pathInfo}");
            routes.IgnoreRoute("Shared/{*pathInfo}");
            routes.IgnoreRoute("Upload/{*pathInfo}");
            routes.IgnoreRoute("Views/{*pathInfo}");
            routes.IgnoreRoute("WebService/{*pathInfo}");
            routes.IgnoreRoute("XSD/{*pathInfo}");
            routes.IgnoreRoute("__browserLink/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new
                {
                    controller = ConfigurationManager.AppSettings["MvcDefaultController"],
                    action = ConfigurationManager.AppSettings["MvcDefaultAction"],
                    id = UrlParameter.Optional
                } // Parameter defaults
            );
            routes.MapRoute("domain", "", new { controller = "Web", action = "Index" });   //添加访问域名路由

        }
    }
}
