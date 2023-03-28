using SpaceFlightApp.Models.UserDetails;
using SpaceFlightApp.Models.Questions;
using SpaceFlightApp.Models.News;
using SpaceFlightApp.Models.Flights;
using SpaceFlightApp.Models.Discussion;




namespace WebApiSpaceFlight.Data
{
  public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
       
        public DbSet<Userr> UserDetailsList { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet <News> NewsArticles { get; set; }
        public DbSet <UpcomingFlights> UpcomingFlights { get; set; }
        public DbSet <Discussion> DiscussionTopics { get; set; }
    }
}