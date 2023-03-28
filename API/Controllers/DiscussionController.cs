using Microsoft.AspNetCore.Mvc;
using SpaceFlightApp.Models.Discussion;

namespace WebApiSpaceFlight.Controllers
{

  [Route("api/[controller]")]
  [ApiController]

  public class DiscussionController : ControllerBase 
  {
    private static List<Discussion> topic = new List<Discussion> 
      {
        new Discussion { 
            Title = "Is it worth it going to space?",
            DiscussionBody = "Glowing reviews from astronauts may be a sponsered attempt to promote going to space. But is this really the case?", 
            CreateDate = DateTime.MinValue,
            DiscussionSaved = true || false,
        }
      };

    private readonly DataContext _context;
    public DiscussionController(DataContext context)
    {
          _context = context;
    }

    [HttpPost("PostDiscussion")]
    public async Task<ActionResult<List<Discussion>>> PostDiscussion(Discussion topic)
    {
      _context.DiscussionTopics.Add(topic);
      await _context.SaveChangesAsync();
      return Ok(await _context.DiscussionTopics.ToListAsync());
    }

//  FOR USE IN THE PROFILE CONTROLLER:

// [HttpGet(Name = "GetSavedDiscussions")]
//     public async Task<ActionResult<List<Discussion>>> GetSavedDiscussions(bool DiscussionSaved)
//     {
//      var saved = await _context.DiscussionTopics.Where(x=>x.DiscussionSaved==true).ToListAsync(); 

//       if (saved == null)
//          return BadRequest("Clicked news articles not found.");
      
//       return Ok(saved); 
      
//   }


  [HttpGet("GetAllDiscussions")]
    public async Task<ActionResult<List<Discussion>>> GetAllDiscussions()
    {
 var results = await _context.DiscussionTopics.Where(x=>x.DiscussionSaved==true||false).ToListAsync(); 
          if(results == null)
          return BadRequest("Saved discussions not found");
      return Ok(results);   
    }  
  }
}
