using Infrastructure.Application.Core.BusinessServices;
using Infrastructure.Application.Core.DataServices;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.Application.Storage.StudentTest
{
    public class StudentTestRepository : BaseBusinessService<Domain.Entities.StudentTest, StudentTestDto>
    {
        public StudentTestRepository(IDataService<Domain.Entities.StudentTest> dataService) : base(dataService)
        {
        }
    }
}