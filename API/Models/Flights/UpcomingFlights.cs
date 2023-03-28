namespace SpaceFlightApp.Models.Flights
{
  public class UpcomingFlights
  {
    public int Id { get; set; }
    public string AnnouncementURL { get; set; } = String.Empty;
    public string Title { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;

    public DateTime CreateDate { get; set; } = File.GetCreationTime(@"C:\Users\jessi\source\repos\JasperPrice69\SpaceTourismProject\WebApiSpaceFlight\SpaceTourismProject\WebApiSpaceFlight\bin\Debug\net6.0\WebApiSpaceFlight");
    public DateTime LastUpdated { get; set; } = File.GetLastWriteTime(@"C:\Users\jessi\source\repos\JasperPrice69\SpaceTourismProject\WebApiSpaceFlight\SpaceTourismProject\WebApiSpaceFlight\bin\Debug\net6.0\WebApiSpaceFlight");

}
}