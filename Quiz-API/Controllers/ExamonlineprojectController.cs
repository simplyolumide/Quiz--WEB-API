using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiz_API.Models;
using System.Net.Http;

namespace Quiz_API.Controllers
{
    public class ExamonlineprojectController : Controller
    {
        // GET: Examonlineproject
        public ActionResult Index()
        {
            IEnumerable<OnlineexamClass> oec = null;

            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44300/api/Exam");

            var consumeapi = hc.GetAsync("Exam");
            consumeapi.Wait();

            var readdata = consumeapi.Result;
            if (readdata.IsSuccessStatusCode)
            {
                var displaydata = readdata.Content.ReadAsAsync<IList<OnlineexamClass>>();
                displaydata.Wait();
                oec = displaydata.Result;
            }
            return View(oec);
        }
    }
}