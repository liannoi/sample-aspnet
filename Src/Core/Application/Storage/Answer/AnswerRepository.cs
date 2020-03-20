using ApplicationGeneric.Core.BusinessServices;
using ApplicationGeneric.Core.DataServices;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.Application.Storage.Answer
{
    public class AnswerRepository : BaseBusinessService<Domain.Entities.Answer, AnswerDto>
    {
        public AnswerRepository(IDataService<Domain.Entities.Answer> dataService) : base(dataService)
        {
        }
    }
}