using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ASP_DZ3.Util;
using Ninject;
using Ninject.Web.Mvc;

namespace ASP_DZ3
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            NinjectModule registr = new NinjectRegistration();
            IKernel kernel = new StandardKernel(registr);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
