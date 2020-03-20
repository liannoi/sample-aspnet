using Infrastructure.Application.Core.BusinessServices;
using Infrastructure.Application.Core.DataServices;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.Application.Storage.Answer
{
    public sealed class AnswerRepository : BaseBusinessService<Domain.Entities.Answer, AnswerDto>
    {
        public AnswerRepository(IDataService<Domain.Entities.Answer> dataService) : base(dataService)
        {
            Mapper = InitializeMapper();
        }
    }
}