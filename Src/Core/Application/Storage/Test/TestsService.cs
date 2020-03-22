using System.Data.Entity;
using Infrastructure.Application.Core.DataServices;

namespace SampleAspNet.Application.Storage.Test
{
    public class TestsService : BaseDataService<Domain.Entities.Test>
    {
        public TestsService(DbContext context) : base(context)
        {
        }
    }
}