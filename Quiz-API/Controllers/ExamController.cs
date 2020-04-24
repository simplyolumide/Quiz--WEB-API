using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Quiz_API.Models;

namespace Quiz_API.Controllers
{
    public class ExamController : ApiController
    {
        [HttpGet]
        public IHttpActionResult onlineexam()
        { 
        quizEntities nd = new quizEntities();
        IList<OnlineexamClass> oe = nd.onlineexams.Include("onlineexam").Select(x => new OnlineexamClass()
        {
            Qid = x.Qid,
            Question = x.Question,
            Option1 = x.option1,
            Option2 = x.option2,
            Option3 = x.option3,
            Option4 = x.option4,
            corrans = x.Correctans

        }).ToList<OnlineexamClass>();
        return Ok(oe);
    }
    }
}
