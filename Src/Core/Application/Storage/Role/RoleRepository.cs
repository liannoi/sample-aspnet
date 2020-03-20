using Infrastructure.Application.Core.BusinessServices;
using Infrastructure.Application.Core.DataServices;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.Application.Storage.Role
{
    public sealed class RoleRepository : BaseBusinessService<Domain.Entities.Role, RoleDto>
    {
        public RoleRepository(IDataService<Domain.Entities.Role> dataService) : base(dataService)
        {
            Mapper = InitializeMapper();
        }
    }
}