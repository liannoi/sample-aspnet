using Infrastructure.Application.Core.BusinessServices;
using Infrastructure.Application.Core.DataServices;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.Application.Storage.User
{
    public sealed class UsersRepository : BaseBusinessService<Domain.Entities.User, UserDto>
    {
        public UsersRepository(IDataService<Domain.Entities.User> dataService) : base(dataService)
        {
            Mapper = InitializeMapper();
        }
    }
}