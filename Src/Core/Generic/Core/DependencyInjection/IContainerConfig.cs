using Autofac;

namespace ApplicationGeneric.Core.DependencyInjection
{
    public interface IContainerConfig
    {
        IContainer Container { get; }
        IContainer Build();
    }
}