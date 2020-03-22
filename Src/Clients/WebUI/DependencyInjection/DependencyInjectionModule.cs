using Autofac;
using Infrastructure.Application.Core.Helpers;

namespace SampleAspNet.WebUI.DependencyInjection
{
    public class DependencyInjectionModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApiFetcher>().As<IApiFetcher>();
        }
    }
}