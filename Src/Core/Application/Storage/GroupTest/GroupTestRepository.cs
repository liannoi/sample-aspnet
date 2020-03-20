using ApplicationGeneric.Core.BusinessServices;
using ApplicationGeneric.Core.DataServices;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.Application.Storage.GroupTest
{
    public class GroupTestRepository : BaseBusinessService<Domain.Entities.GroupTest, GroupTestDto>
    {
        public GroupTestRepository(IDataService<Domain.Entities.GroupTest> dataService) : base(dataService)
        {
        }
    }
}