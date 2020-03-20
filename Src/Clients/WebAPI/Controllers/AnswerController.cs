using System.Web.Http;
using Infrastructure.Application.Core.BusinessServices;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.WebApi.Controllers
{
    public class AnswerController : ApiController
    {
        private readonly IBusinessService<AnswerDto> _answerService;

        public AnswerController(IBusinessService<AnswerDto> answerService)
        {
            _answerService = answerService;
        }

        [HttpGet]
        [Route("api/answers/")]
        public IHttpActionResult GetAll()
        {
            return Ok(_answerService.Select());
        }
    }
}