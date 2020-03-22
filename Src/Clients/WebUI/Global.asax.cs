using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SampleAspNet.WebUI.DependencyInjection;

namespace SampleAspNet.WebUI
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            // Autofac MVC.
            var unused = new MvcContainerConfig();

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}