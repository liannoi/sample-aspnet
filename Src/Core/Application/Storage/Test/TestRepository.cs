using Infrastructure.Application.Core.BusinessServices;
using Infrastructure.Application.Core.DataServices;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.Application.Storage.Test
{
    public class TestRepository : BaseBusinessService<Domain.Entities.Test, TestDto>
    {
        public TestRepository(IDataService<Domain.Entities.Test> dataService) : base(dataService)
        {
        }
    }
}