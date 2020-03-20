using ApplicationGeneric.Core.BusinessServices;
using ApplicationGeneric.Core.DataServices;
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