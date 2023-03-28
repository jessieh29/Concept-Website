using Microsoft.AspNetCore.Mvc;
using SpaceFlightApp.Models.News;

namespace WebApiSpaceFlight.Controllers
{

  [Route("api/[controller]/News")]
  [ApiController]

  public class NewsController : ControllerBase 
  {
    private static List<News> articles = new List<News> 
      {
        new News { 
            Id = 1,
            NewsURL = "https://www.space.com/blue-origin-delays-space-tourist-launch-ns21",
            Title = "Blue Origin delays next space tourist launch from May 20 due to vehicle issue",
            Description = "A new target launch date has not yet been announced.", 
           CreateDate = DateTime.MinValue,
            LastUpdated = DateTime.MaxValue,
            ClickedNews = true, 
        }
      };
 private readonly DataContext _context;
    public NewsController(DataContext context)
    {
    _context = context;
    }
    
    [HttpGet("GetAllNews")]
    public async Task<ActionResult<List<News>>> GetAllNews()
    {
      return Ok(await _context.NewsArticles.ToListAsync());
    }

   [HttpGet("GetClickedNews")]
    public async Task<ActionResult<News>> GetClickedNewsAsync(bool ClickedNews)
    {
      var results = await _context.NewsArticles.Where(x=>x.ClickedNews==true).ToListAsync(); 
          if(results == null)
          return BadRequest("Clicked news articles not found");
      return Ok(results);     
  }

[HttpPut("SetNewsToClicked")]
        public async Task<ActionResult<News>> SetNewsToClicked(News request)
        {
            var response = await _context.NewsArticles.FindAsync(request.Id);
            // if(response.ClickedNews == true)
            // {
            //     return Ok(await _context.NewsArticles.Where(x=>x.ClickedNews==true).ToListAsync());
            // }

           response.ClickedNews = request.ClickedNews;

           await _context.SaveChangesAsync();
           return Ok(await _context.NewsArticles.ToListAsync());
        }

[HttpGet("GetNewsByID")]
    public async Task<ActionResult<List<News>>> GetNews(int id)
    {
      var results = await _context.NewsArticles.FindAsync(id);
      if (results == null)
          return BadRequest("News article not found.");
      return Ok(results);
    }
}
}

