using ApplicationGeneric.Core.BusinessServices;
using ApplicationGeneric.Core.DataServices;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.Application.Storage.Role
{
    public class RoleRepository : BaseBusinessService<Domain.Entities.Role, RoleDto>
    {
        public RoleRepository(IDataService<Domain.Entities.Role> dataService) : base(dataService)
        {
        }
    }
}