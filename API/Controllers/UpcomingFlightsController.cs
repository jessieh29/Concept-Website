using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpaceFlightApp.Models.Flights;
using WebApiSpaceFlight;

namespace WebApiSpaceFlight.Controllers{

  [Route("api/[controller]")]
  [ApiController]

  public class UpcomingFlightsController : ControllerBase 
  {
    private static List<UpcomingFlights> flights = new List<UpcomingFlights> 
      {
        new UpcomingFlights { 
            Id = 1,
            AnnouncementURL = "https://www.space.com/blue-origin-delays-space-tourist-launch-ns21",
            Title = "Blue Origin delays next space tourist launch from May 20 due to vehicle issue",
            Description = "Previously May 28th. A new target launch date has not yet been announced.", 
            LastUpdated = DateTime.MaxValue,
            CreateDate = DateTime.MinValue
        }
      };

    private readonly DataContext _context;
    public UpcomingFlightsController(DataContext context)
    {
    _context = context;
    }

    [HttpGet("GetUpcomingFlights")]
    public async Task<ActionResult<List<UpcomingFlights>>> GetAllUpcomingFlights()
    {
      return Ok(await _context.UpcomingFlights.ToListAsync());
    }

  }
}