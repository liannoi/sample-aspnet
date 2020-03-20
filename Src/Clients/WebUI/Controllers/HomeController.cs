using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.WebUI.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ViewResult> IndexMvc()
        {
            return View(await FetchAsync());
        }

        // ReSharper disable once MemberCanBeMadeStatic.Local
        private async Task<IEnumerable<AnswerDto>> FetchAsync()
        {
            List<AnswerDto> result = null;
            await new HttpClient()
                .GetAsync("https://localhost:44398/api/answers")
                .ContinueWith(async taskResponse =>
                    result = JsonConvert.DeserializeObject<List<AnswerDto>>(
                        await (await taskResponse).Content.ReadAsStringAsync()));
            return result;
        }
    }
}