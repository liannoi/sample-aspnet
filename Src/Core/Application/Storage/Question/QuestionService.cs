using System.Data.Entity;
using ApplicationGeneric.Core.DataServices;

namespace SampleAspNet.Application.Storage.Question
{
    public class QuestionService : BaseDataService<Domain.Entities.Question>
    {
        public QuestionService(DbContext context) : base(context)
        {
        }
    }
}