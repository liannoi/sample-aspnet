using System.Data.Entity;
using Infrastructure.Application.Core.DataServices;

namespace SampleAspNet.Application.Storage.UserRole
{
    public class UserRolesService : BaseDataService<Domain.Entities.UserRole>
    {
        public UserRolesService(DbContext context) : base(context)
        {
        }
    }
}