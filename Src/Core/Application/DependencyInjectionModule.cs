using System.Data.Entity;
using ApplicationGeneric.Core.BusinessServices;
using ApplicationGeneric.Core.DataServices;
using Autofac;
using SampleAspNet.Application.Entities;
using SampleAspNet.Application.Storage.User;
using SampleAspNet.Domain.Entities;
using SampleAspNet.Persistence;

namespace SampleAspNet.Application
{
    public class DependencyInjectionModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            RegisterRepository<UserService, User, UserRepository, UserDto>(builder);
            builder.RegisterType<TestingSystemContext>().As<DbContext>();
        }

        private void RegisterRepository<TStorage, TEntity, TRepository, TBEntity>(ContainerBuilder builder)
            where TEntity : class, new() where TBEntity : class, new()
        {
            builder.RegisterType<TStorage>().As<IDataService<TEntity>>();
            builder.RegisterType<TRepository>().As<IBusinessService<TBEntity>>();
        }
    }
}