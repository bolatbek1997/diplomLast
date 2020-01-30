using DiplomLast.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DiplomLast
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
         
                //var a = new AppDbInitializer();
                //Database.SetInitializer<ApplicationDbContext>(a);

                //Database.SetInitializer(new AppDbInitializer());
          
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
