using System.Data.Entity;
using Infrastructure.Application.Core.DataServices;

namespace SampleAspNet.Application.Storage.GroupTest
{
    public class GroupTestService : BaseDataService<Domain.Entities.GroupTest>
    {
        public GroupTestService(DbContext context) : base(context)
        {
        }
    }
}