using System.Data.Entity;
using Infrastructure.Application.Core.DataServices;

namespace SampleAspNet.Application.Storage.Question
{
    public class QuestionsService : BaseDataService<Domain.Entities.Question>
    {
        public QuestionsService(DbContext context) : base(context)
        {
        }
    }
}