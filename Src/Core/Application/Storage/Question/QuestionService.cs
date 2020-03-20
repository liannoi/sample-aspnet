using System.Data.Entity;
using Infrastructure.Application.Core.DataServices;

namespace SampleAspNet.Application.Storage.Question
{
    public class QuestionService : BaseDataService<Domain.Entities.Question>
    {
        public QuestionService(DbContext context) : base(context)
        {
        }
    }
}