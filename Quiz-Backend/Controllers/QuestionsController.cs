using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Quiz_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {



        // GET api/values
        [HttpGet]
        public IEnumerable<Models.Question> Get()
        {
            return new Models.Question[] {
                 new Models.Question { Text = "Hello 1"},
                 new Models.Question { Text = "Hello 2"},
                 new Models.Question { Text = "Hello 3"}
            };
        }


        // POST api/questions
        [HttpPost]
        public void Post([FromBody] Models.Question  question)
        {
            
        }
    }
}