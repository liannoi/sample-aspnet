using System.Web;
using System.Web.Http;

namespace SampleAspNet.WebApi
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            // Autofac Web API.
            var unused = new WebApiContainerConfig();

            GlobalConfiguration.Configure(WebApiConfig.Register);

            // Removing the priority XML.
            GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters
                .XmlFormatter);
        }
    }
}