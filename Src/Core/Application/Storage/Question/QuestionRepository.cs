using ApplicationGeneric.Core.BusinessServices;
using ApplicationGeneric.Core.DataServices;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.Application.Storage.Question
{
    public class QuestionRepository : BaseBusinessService<Domain.Entities.Question, QuestionDto>
    {
        public QuestionRepository(IDataService<Domain.Entities.Question> dataService) : base(dataService)
        {
        }
    }
}