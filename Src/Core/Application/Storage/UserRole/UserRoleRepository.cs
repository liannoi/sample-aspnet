using ApplicationGeneric.Core.BusinessServices;
using ApplicationGeneric.Core.DataServices;
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