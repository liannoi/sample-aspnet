using System.Data.Entity;
using Infrastructure.Application.Core.DataServices;

namespace SampleAspNet.Application.Storage.Answer
{
    public class AnswerService : BaseDataService<Domain.Entities.Answer>
    {
        public AnswerService(DbContext context) : base(context)
        {
        }
    }
}