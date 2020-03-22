using System.Data.Entity;
using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Infrastructure.Application.Core.DependencyInjection;
using SampleAspNet.Application;
using SampleAspNet.Persistence;

namespace SampleAspNet.WebApi
{
    public sealed class WebApiContainerConfig : ContainerConfig<DependencyInjectionModule>
    {
        public WebApiContainerConfig()
        {
            // Not used.
            Container = Build();
        }

        public override IContainer Build()
        {
            // Initialization.
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;

            // Registration.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterWebApiFilterProvider(config);
            builder.RegisterWebApiModelBinderProvider();
            builder.RegisterType<TestingSystemContext>().As<DbContext>();
            builder.RegisterModule<DependencyInjectionModule>();

            // Setup.
            config.DependencyResolver = new AutofacWebApiDependencyResolver(builder.Build());

            // Not used.
            return null;
        }
    }
}