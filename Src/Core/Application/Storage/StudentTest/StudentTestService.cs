using System.Data.Entity;
using ApplicationGeneric.Core.DataServices;

namespace SampleAspNet.Application.Storage.StudentTest
{
    public class StudentTestService : BaseDataService<Domain.Entities.StudentTest>
    {
        public StudentTestService(DbContext context) : base(context)
        {
        }
    }
}