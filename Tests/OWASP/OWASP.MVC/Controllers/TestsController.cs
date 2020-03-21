using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using SampleAspNet.Application.Entities;

namespace SampleAspNet.Tests.Owasp.Controllers
{
    public class TestsController : Controller
    {
        //
        // OWASP 2020 Top 10 Web Application Security Risks
        //
        // (?) A1 - Injection.
        // We are completely safe from this danger when working through the Web
        // API, unfortunately, when working with this database, I did not come
        // up with what queries can serve for tests.
        //
        // (?) A2 - Broken Authentication.
        // I’m skipping for now, because at the moment I’m not familiar with
        // authorization.
        //
        // (?) A3 - Sensitive Data Exposure.
        // This vulnerability implies: transferring data to the client in a
        // clean (not encrypted) form, using insecure protocols (SMTP, HTTP)
        // and storing passwords in their pure form or using weak hashing
        // algorithms, as well as caching of critical and confidential
        // information. In this example, all risk avoidance conditions are met,
        // except that I stored MD5 hashed passwords. Caching is not used,
        // because at the moment, I am not familiar with it.
        //
        // A4 - XML External Entities (XXE).
        // This vulnerability implies the use of SOAP services and XML
        // serialization for data transfer. This is deprecated and in this
        // example, REST and JSON are used.
        //
        // (?) A5 - Broken Access Control.
        // To ensure security against this vulnerability, it is necessary to
        // correctly configure authorization and use CORS carefully (giving
        // access to service controllers).
        //
        // A6 - Security Misconfiguration.
        // All errors and exceptional situations that occur, especially when
        // working in a production environment, must be processed and displayed
        // in the form of a beautiful, clear and understandable notification.
        // But in no case, do not display the standard Stack Trace. In this
        // example, I did not implement this, so as not to bother, but I will
        // definitely take into account when developing serious applications.
        //
        // A7 - Cross-Site Scripting (XSS).
        // No code should be executed in input fields. In MVC 5, this is known
        // vulnerability and when trying to call JS in the input line, an
        // exception is thrown. According to risk A6, everything is correct,
        // but the error should appear in a separate beautiful and simple
        // window.
        //
        // A8 - Insecure Deserialization.
        // Check that we are deserializing. Does the user have to receive data
        // from here in principle. Mainly used in the context of HTTP cookies
        // deserialization.
        //
        // A9 - Using Components with Known Vulnerabilities.
        // Do not use knowingly vulnerable components.
        //
        // A10 - Insufficient Logging & Monitoring.
        // Provide good logging and monitoring of what is happening.
        //
        //
        [HttpGet]
        public async Task<ViewResult> Index()
        {
            return View((await FetchAsync()).Take(50));
        }

        [HttpGet]
        public async Task<ViewResult> Update(int id)
        {
            return View((await FetchAsyncOne(id)).FirstOrDefault());
        }

        [HttpPost]
        public RedirectToRouteResult Update(AnswerDto entity)
        {
            return RedirectToAction(nameof(Index));
        }

        // ReSharper disable once MemberCanBeMadeStatic.Local
        private async Task<IEnumerable<AnswerDto>> FetchAsyncOne(int id)
        {
            List<AnswerDto> result = null;
            await new HttpClient()
                .GetAsync($"https://localhost:44398/api/answers/{id}")
                .ContinueWith(async taskResponse =>
                    result = JsonConvert.DeserializeObject<List<AnswerDto>>(
                        await (await taskResponse).Content.ReadAsStringAsync()));
            return result;
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