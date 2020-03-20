using System.Data.Entity;
using ApplicationGeneric.Core.DataServices;

namespace SampleAspNet.Application.Storage.Test
{
    public class TestService : BaseDataService<Domain.Entities.Test>
    {
        public TestService(DbContext context) : base(context)
        {
        }
    }
}