using ApplicationGeneric.Core.BusinessServices;
using ApplicationGeneric.Core.DataServices;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.Application.Storage.User
{
    //
    // Each such repository can redefine the Mapper initialization method to
    // specify specific properties, and it can also contain safe methods that
    // can be called instead of the usual ones to handle exceptions (both
    // corporate logic - described in Domain, and business logic - described in
    // Application) . At the same time, Service - can catch only business logic
    // errors, and Repository - both types. Corporate logic errors include the
    // lack of records, and returning NULL means violating the principle of the
    // application. Business logic errors include: mapping errors, database
    // connections, missing connection strings, errors of the Autofac IoC
    // container, and more ...
    //
    //
    public sealed class UserRepository : BaseBusinessService<Domain.Entities.User, UserDto>
    {
        public UserRepository(IDataService<Domain.Entities.User> dataService) : base(dataService)
        {
            Mapper = InitializeMapper();
        }
    }
}