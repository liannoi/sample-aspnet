using Infrastructure.Application.Core.BusinessServices;
using Infrastructure.Application.Core.DataServices;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.Application.Storage.Question
{
    public sealed class QuestionRepository : BaseBusinessService<Domain.Entities.Question, QuestionDto>
    {
        public QuestionRepository(IDataService<Domain.Entities.Question> dataService) : base(dataService)
        {
            Mapper = InitializeMapper();
        }
    }
}