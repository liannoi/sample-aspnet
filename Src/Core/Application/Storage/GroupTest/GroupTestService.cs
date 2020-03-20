using System.Data.Entity;
using ApplicationGeneric.Core.DataServices;

namespace SampleAspNet.Application.Storage.GroupTest
{
    public class GroupTestService : BaseDataService<Domain.Entities.GroupTest>
    {
        public GroupTestService(DbContext context) : base(context)
        {
        }
    }
}