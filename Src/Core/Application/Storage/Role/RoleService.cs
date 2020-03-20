using System.Data.Entity;
using Infrastructure.Application.Core.DataServices;

namespace SampleAspNet.Application.Storage.Role
{
    public class RoleService : BaseDataService<Domain.Entities.Role>
    {
        public RoleService(DbContext context) : base(context)
        {
        }
    }
}