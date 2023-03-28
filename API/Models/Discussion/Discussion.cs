using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpaceFlightApp.Models.Discussion
{
  public class Discussion
  {
    [Key]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(100")]
    public string Title { get; set; } = String.Empty;

    [Required]
    [Column(TypeName = "nvarchar(1000")]
    public string DiscussionBody { get; set; } = String.Empty;

    [Required]
    [Column(TypeName = "varchar(8)")]
    public DateTime CreateDate { get; set; } = File.GetCreationTime(@"C:\Users\jessi\source\repos\JasperPrice69\SpaceTourismProject\WebApiSpaceFlight\SpaceTourismProject\WebApiSpaceFlight\bin\Debug\net6.0\WebApiSpaceFlight");

    [Required]
    public bool DiscussionSaved { get; set; } = true || false;
}
    }