using System.Data.Entity;
using Infrastructure.Application.Core.DataServices;

namespace SampleAspNet.Application.Storage.StudentTest
{
    public class StudentTestsService : BaseDataService<Domain.Entities.StudentTest>
    {
        public StudentTestsService(DbContext context) : base(context)
        {
        }
    }
}