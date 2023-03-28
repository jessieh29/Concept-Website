namespace SpaceFlightApp.Models.News
{
  public class News
  {
    public int Id { get; set; }
    public string NewsURL { get; set; } = String.Empty;
    public string Title { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;

    public DateTime CreateDate { get; set; } = File.GetCreationTime(@"C:\Users\jessi\source\repos\JasperPrice69\SpaceTourismProject\WebApiSpaceFlight\SpaceTourismProject\WebApiSpaceFlight\bin\Debug\net6.0\WebApiSpaceFlight");
    public DateTime LastUpdated { get; set; } = File.GetLastWriteTime(@"C:\Users\jessi\source\repos\JasperPrice69\SpaceTourismProject\WebApiSpaceFlight\SpaceTourismProject\WebApiSpaceFlight\bin\Debug\net6.0\WebApiSpaceFlight");
    public bool ClickedNews { get; set; } = false;

// Console.WriteLine(check ? "Checked" : "Not checked");  // output: Checked

// Console.WriteLine(false ? "Checked" : "Not checked");  // output: Not Checked
}
}