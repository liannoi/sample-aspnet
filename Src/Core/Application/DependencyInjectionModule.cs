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
            RegisterStorage<AnswersService, Answer, AnswersRepository, AnswerDto>(builder);
            RegisterStorage<GroupsService, Group, GroupsRepository, GroupDto>(builder);
            RegisterStorage<GroupTestsService, GroupTest, GroupTestsRepository, GroupTestDto>(builder);
            RegisterStorage<QuestionsService, Question, QuestionsRepository, QuestionDto>(builder);
            RegisterStorage<RolesService, Role, RolesRepository, RoleDto>(builder);
            RegisterStorage<StudentTestsService, StudentTest, StudentTestsRepository, StudentTestDto>(builder);
            RegisterStorage<TestsService, Test, TestsRepository, TestDto>(builder);
            RegisterStorage<UsersService, User, UsersRepository, UserDto>(builder);
            RegisterStorage<UserRolesService, UserRole, UserRolesRepository, UserRoleDto>(builder);
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