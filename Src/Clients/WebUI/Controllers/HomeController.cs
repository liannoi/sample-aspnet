using System.Threading.Tasks;
using System.Web.Mvc;
using Infrastructure.Application.Core.Helpers;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApiFetcher _apiFetcher;

        public HomeController(IApiFetcher apiFetcher)
        {
            _apiFetcher = apiFetcher;
        }

        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ViewResult> Sample()
        {
            return View(await _apiFetcher.FetchAsync<AnswerDto>("https://localhost:44398/api/answers"));
        }
    }
}