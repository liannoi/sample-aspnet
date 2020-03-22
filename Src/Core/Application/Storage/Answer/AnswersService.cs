using System.Data.Entity;
using Infrastructure.Application.Core.DataServices;

namespace SampleAspNet.Application.Storage.Answer
{
    public class AnswersService : BaseDataService<Domain.Entities.Answer>
    {
        public AnswersService(DbContext context) : base(context)
        {
        }
    }
}