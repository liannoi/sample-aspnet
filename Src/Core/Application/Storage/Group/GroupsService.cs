using System.Data.Entity;
using Infrastructure.Application.Core.DataServices;

namespace SampleAspNet.Application.Storage.Group
{
    public class GroupsService : BaseDataService<Domain.Entities.Group>
    {
        public GroupsService(DbContext context) : base(context)
        {
        }
    }
}