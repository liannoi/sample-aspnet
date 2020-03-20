using System.Data.Entity;
using ApplicationGeneric.Core.DataServices;

namespace SampleAspNet.Application.Storage.Role
{
    public class RoleService : BaseDataService<Domain.Entities.Role>
    {
        public RoleService(DbContext context) : base(context)
        {
        }
    }
}