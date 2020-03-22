using Infrastructure.Application.Core.BusinessServices;
using Infrastructure.Application.Core.DataServices;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.Application.Storage.GroupTest
{
    public sealed class GroupTestsRepository : BaseBusinessService<Domain.Entities.GroupTest, GroupTestDto>
    {
        public GroupTestsRepository(IDataService<Domain.Entities.GroupTest> dataService) : base(dataService)
        {
            Mapper = InitializeMapper();
        }
    }
}