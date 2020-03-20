using Infrastructure.Application.Core.BusinessServices;
using Infrastructure.Application.Core.DataServices;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.Application.Storage.UserRole
{
    public class UserRoleRepository : BaseBusinessService<Domain.Entities.UserRole, UserRoleDto>
    {
        public UserRoleRepository(IDataService<Domain.Entities.UserRole> dataService) : base(dataService)
        {
        }
    }
}