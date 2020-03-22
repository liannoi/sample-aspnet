using System.Data.Entity;
using Infrastructure.Application.Core.DataServices;

namespace SampleAspNet.Application.Storage.GroupTest
{
    public class GroupTestsService : BaseDataService<Domain.Entities.GroupTest>
    {
        public GroupTestsService(DbContext context) : base(context)
        {
        }
    }
}