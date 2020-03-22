using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Infrastructure.Application.Core.DependencyInjection;

namespace SampleAspNet.WebUI.DependencyInjection
{
    public sealed class MvcContainerConfig : ContainerConfig<DependencyInjectionModule>
    {
        public MvcContainerConfig()
        {
            // Not used.
            Container = Build();
        }

        public override IContainer Build()
        {
            // Initialization.
            var containerBuilder = new ContainerBuilder();

            // Registration.
            containerBuilder.RegisterControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            containerBuilder.RegisterModule<DependencyInjectionModule>();

            // Setup.
            DependencyResolver.SetResolver(new AutofacDependencyResolver(containerBuilder.Build()));

            // Not used.
            return null;
        }
    }
}