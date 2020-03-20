using System.Data.Entity;
using Infrastructure.Application.Core.DataServices;

namespace SampleAspNet.Application.Storage.Test
{
    public class TestService : BaseDataService<Domain.Entities.Test>
    {
        public TestService(DbContext context) : base(context)
        {
        }
    }
}