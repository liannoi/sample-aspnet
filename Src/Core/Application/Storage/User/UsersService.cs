using System.Data.Entity;
using Infrastructure.Application.Core.DataServices;

namespace SampleAspNet.Application.Storage.User
{
    public sealed class UsersService : BaseDataService<Domain.Entities.User>
    {
        public UsersService(DbContext context) : base(context)
        {
        }
    }
}