using System.Data.Entity;
using ApplicationGeneric.Core.DataServices;

namespace SampleAspNet.Application.Storage.UserRole
{
    public class UserRoleService : BaseDataService<Domain.Entities.UserRole>
    {
        public UserRoleService(DbContext context) : base(context)
        {
        }
    }
}