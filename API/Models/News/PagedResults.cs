namespace SpaceFlightApp.Models.News
{
  public class PagedResults<T>
  {
    public IEnumerable<T> Items { get; set; }

    public int TotalCount { get; set; }

  }
}
