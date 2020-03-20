using System.Data.Entity;
using Infrastructure.Application.Core.DataServices;

namespace SampleAspNet.Application.Storage.User
{
    public sealed class UserService : BaseDataService<Domain.Entities.User>
    {
        public UserService(DbContext context) : base(context)
        {
        }
    }
}