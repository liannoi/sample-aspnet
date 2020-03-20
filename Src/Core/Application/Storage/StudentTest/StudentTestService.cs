using System.Data.Entity;
using Infrastructure.Application.Core.DataServices;

namespace SampleAspNet.Application.Storage.StudentTest
{
    public class StudentTestService : BaseDataService<Domain.Entities.StudentTest>
    {
        public StudentTestService(DbContext context) : base(context)
        {
        }
    }
}