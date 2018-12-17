using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Quiz_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        readonly QuizContext context;

        public QuestionsController(QuizContext context)
        {
            this.context = context;
        }
        // GET api/question
        [HttpGet]
        public IEnumerable<Models.Question> Get()
        {
            return context.Questions;
        }


        // POST api/questionsgit 
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Models.Question  question)
        {
            context.Questions.Add(question);
            await context.SaveChangesAsync();
            return Ok(question);

        }

        // PUT api/question/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Models.Question question)
        {
            if(id != question.Id)
            {
                return BadRequest();
            }
            //var question = await context.Questions.SingleOrDefaultAsync(q => q.Id == id);
            context.Entry(question).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return Ok(question);
        }
    }
}