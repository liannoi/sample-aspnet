using Infrastructure.Application.Core.BusinessServices;
using Infrastructure.Application.Core.DataServices;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.Application.Storage.Group
{
    public sealed class GroupsRepository : BaseBusinessService<Domain.Entities.Group, GroupDto>
    {
        public GroupsRepository(IDataService<Domain.Entities.Group> dataService) : base(dataService)
        {
            Mapper = InitializeMapper();
        }
    }
}