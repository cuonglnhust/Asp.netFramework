using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Tedushop.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Register các App_start
            AreaRegistration.RegisterAllAreas();// register các Areas
            GlobalConfiguration.Configure(WebApiConfig.Register);// register webapi
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);// register Filter
            RouteConfig.RegisterRoutes(RouteTable.Routes);// register RouteConfig
            BundleConfig.RegisterBundles(BundleTable.Bundles);//register Bundle
        }
    }
}
