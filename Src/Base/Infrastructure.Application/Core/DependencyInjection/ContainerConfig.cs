using Autofac;
using Autofac.Core;

namespace Infrastructure.Application.Core.DependencyInjection
{
    public sealed class ContainerConfig<TModule> : IContainerConfig where TModule : IModule, new()
    {
        public ContainerConfig()
        {
            Container = Build();
        }

        public IContainer Container { get; }

        public IContainer Build()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<TModule>();
            return builder.Build();
        }
    }
}