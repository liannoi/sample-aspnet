using Infrastructure.Application.Core.BusinessServices;
using Infrastructure.Application.Core.DataServices;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.Application.Storage.Group
{
    public class GroupRepository : BaseBusinessService<Domain.Entities.Group, GroupDto>
    {
        public GroupRepository(IDataService<Domain.Entities.Group> dataService) : base(dataService)
        {
        }
    }
}