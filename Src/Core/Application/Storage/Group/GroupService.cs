using System.Data.Entity;
using Infrastructure.Application.Core.DataServices;

namespace SampleAspNet.Application.Storage.Group
{
    public class GroupService : BaseDataService<Domain.Entities.Group>
    {
        public GroupService(DbContext context) : base(context)
        {
        }
    }
}