using Microsoft.AspNetCore.Mvc;
using SpaceFlightApp.Models.Questions;

namespace WebApiSpaceFlight.Controllers
{
  [Route("api/[controller]/AddQuestion")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private static List<Question> _questions = new List<Question>
        {
                new Question {
                    Id = 1,
                    Faq = "How much is a ticket to space?"
                }
            };
            
     private readonly DataContext _context;

        public QuestionController(DataContext context) 
    { 
        _context = context;
    }

     [HttpPost(Name = "PostQuestion")]
        public async Task<ActionResult<List<Question>>> AddQuestion(Question question)
        {
          _context.Questions.Add(question);
          await _context.SaveChangesAsync();

            return Ok(await _context.Questions.ToListAsync());
            
        }

    }
}

     