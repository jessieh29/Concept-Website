using System.ComponentModel.DataAnnotations;

namespace SpaceFlightApp.Models.UserDetails
{
    public class Userr
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Username is required")]
        [MinLength(5, ErrorMessage = "Must be at least 5-20 characters")]
        [MaxLength(20, ErrorMessage = "Must be at least 5-20 characters")]
        public string Username { get; set; } = "SpaceLover69";
        public string Name { get; set; } = "Danny";
        public string Email { get; set; } = "Danny@mail.com";

        public string Gender { get; set; } = "male";
    }
}