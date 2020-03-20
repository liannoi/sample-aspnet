using System.Linq;
using Autofac;
using Infrastructure.Application.Core.BusinessServices;
using Infrastructure.Application.Core.DependencyInjection;
using SampleAspNet.Application;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.Tests.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var business = new ContainerConfig<DependencyInjectionModule>();
            var temp = business.Container.Resolve<IBusinessService<UserDto>>();
            System.Console.WriteLine(temp.Select().FirstOrDefault()?.FirstName);
        }
    }
}