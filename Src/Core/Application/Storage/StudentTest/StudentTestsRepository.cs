using Infrastructure.Application.Core.BusinessServices;
using Infrastructure.Application.Core.DataServices;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.Application.Storage.StudentTest
{
    public sealed class StudentTestsRepository : BaseBusinessService<Domain.Entities.StudentTest, StudentTestDto>
    {
        public StudentTestsRepository(IDataService<Domain.Entities.StudentTest> dataService) : base(dataService)
        {
            Mapper = InitializeMapper();
        }
    }
}