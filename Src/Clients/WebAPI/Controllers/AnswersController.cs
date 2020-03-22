using System.Web.Http;
using System.Web.Http.Cors;
using Infrastructure.Application.Core.BusinessServices;
using SampleAspNet.Application.Entities;
using SampleAspNet.Application.Storage.Answer;
using SampleAspNet.Domain.Exceptions;

namespace SampleAspNet.WebApi.Controllers
{
    [EnableCors("https://localhost:44316", "*", "*")]
    public class AnswersController : ApiController
    {
        private readonly IBusinessService<AnswerDto> _answerService;

        public AnswersController(IBusinessService<AnswerDto> answerService)
        {
            _answerService = answerService;
        }

        [HttpGet]
        [Route("api/answers")]
        public IHttpActionResult GetAll()
        {
            return Ok(_answerService.Select());
        }

        [HttpGet]
        [Route("api/answers/{id}")]
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(_answerService.FindSafe(e => e.AnswerId == id));
            }
            catch (EntityByPredicateNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }

        // Etc...
    }
}