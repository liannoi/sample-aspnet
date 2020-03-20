using Autofac;
using Infrastructure.Application.Core.BusinessServices;
using Infrastructure.Application.Core.DataServices;
using SampleAspNet.Application.Entities;
using SampleAspNet.Application.Storage.Answer;
using SampleAspNet.Application.Storage.Group;
using SampleAspNet.Application.Storage.GroupTest;
using SampleAspNet.Application.Storage.Question;
using SampleAspNet.Application.Storage.Role;
using SampleAspNet.Application.Storage.StudentTest;
using SampleAspNet.Application.Storage.Test;
using SampleAspNet.Application.Storage.User;
using SampleAspNet.Application.Storage.UserRole;
using SampleAspNet.Domain.Entities;

namespace SampleAspNet.Application
{
    public class DependencyInjectionModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            RegisterStorage<AnswerService, Answer, AnswerRepository, AnswerDto>(builder);
            RegisterStorage<GroupService, Group, GroupRepository, GroupDto>(builder);
            RegisterStorage<GroupTestService, GroupTest, GroupTestRepository, GroupTestDto>(builder);
            RegisterStorage<QuestionService, Question, QuestionRepository, QuestionDto>(builder);
            RegisterStorage<RoleService, Role, RoleRepository, RoleDto>(builder);
            RegisterStorage<StudentTestService, StudentTest, StudentTestRepository, StudentTestDto>(builder);
            RegisterStorage<TestService, Test, TestRepository, TestDto>(builder);
            RegisterStorage<UserService, User, UserRepository, UserDto>(builder);
            RegisterStorage<UserRoleService, UserRole, UserRoleRepository, UserRoleDto>(builder);
        }

        // ReSharper disable once MemberCanBeMadeStatic.Local
        private void RegisterStorage<TStorage, TEntity, TRepository, TBEntity>(ContainerBuilder builder)
            where TEntity : class, new() where TBEntity : class, new()
        {
            builder.RegisterType<TStorage>().As<IDataService<TEntity>>();
            builder.RegisterType<TRepository>().As<IBusinessService<TBEntity>>();
        }
    }
}