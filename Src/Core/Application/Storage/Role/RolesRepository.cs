using Infrastructure.Application.Core.BusinessServices;
using Infrastructure.Application.Core.DataServices;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.Application.Storage.Role
{
    public sealed class RolesRepository : BaseBusinessService<Domain.Entities.Role, RoleDto>
    {
        public RolesRepository(IDataService<Domain.Entities.Role> dataService) : base(dataService)
        {
            Mapper = InitializeMapper();
        }
    }
}