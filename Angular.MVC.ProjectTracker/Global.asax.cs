using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Angular.MVC.ProjectTracker;
using Interface.Layer.ProjectTracker.Interfaces;
using Angular.MVC.ProjectTracker.Code;

namespace Angular.MVC.ProjectTracker
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            var config = GlobalConfiguration.Configuration;
            
            ConfigureApi(config);
        }
        public static void ConfigureApi(HttpConfiguration config)
        {
            var container = new  UnityContainer();
            container.LoadConfiguration("application");
             
          //  container.RegisterType<IProjectRepository,ProjectRepository>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityDependencyResolver(container);
          //  config.DependencyResolver
        }
    }
}