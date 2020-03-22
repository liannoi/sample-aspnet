using System.Data.Entity;
using Infrastructure.Application.Core.DataServices;

namespace SampleAspNet.Application.Storage.Role
{
    public class RolesService : BaseDataService<Domain.Entities.Role>
    {
        public RolesService(DbContext context) : base(context)
        {
        }
    }
}