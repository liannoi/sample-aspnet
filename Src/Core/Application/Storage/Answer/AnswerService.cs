using System.Data.Entity;
using ApplicationGeneric.Core.DataServices;

namespace SampleAspNet.Application.Storage.Answer
{
    public class AnswerService : BaseDataService<Domain.Entities.Answer>
    {
        public AnswerService(DbContext context) : base(context)
        {
        }
    }
}