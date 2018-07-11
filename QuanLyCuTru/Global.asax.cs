using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;
using QuanLyCuTru.App_Start;

namespace QuanLyCuTru
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public object MapperConfig { get; private set; }

        protected void Application_Start()
        {
            // Ignore reference loop
            HttpConfiguration config = GlobalConfiguration.Configuration;
            config.Formatters.JsonFormatter
                       .SerializerSettings
                       .ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            // AutoMapper
            MappingConfig.RegisterMapping();

            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.NameIdentifier;

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
        }
    }
}
