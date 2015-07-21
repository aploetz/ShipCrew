using SimpleInjector;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ShipCrew
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static Container container = new Container();

        public static TService GetInstance<TService>()
        where TService : class
        {
            return container.GetInstance<TService>();
        }

        public MvcApplication()
        {
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            container = SimpleInjectorInitializer.Initialize();
        }
    }
}
