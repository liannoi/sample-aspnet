using Infrastructure.Application.Core.BusinessServices;
using Infrastructure.Application.Core.DataServices;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.Application.Storage.UserRole
{
    public sealed class UserRolesRepository : BaseBusinessService<Domain.Entities.UserRole, UserRoleDto>
    {
        public UserRolesRepository(IDataService<Domain.Entities.UserRole> dataService) : base(dataService)
        {
            Mapper = InitializeMapper();
        }
    }
}