using System.ComponentModel.DataAnnotations;

namespace SpaceFlightApp.Models.Discussion
{
  public class DiscussionCreate
  {
        public int DiscussionCommentId { get; set; }

        public int? ParentDiscussionTopicId { get; set; }

        public int DiscussionId { get; set; }

        [Required(ErrorMessage = "Content is required")]
        [MinLength(10, ErrorMessage = "Must be 10-300 characters")]
        [MaxLength(300, ErrorMessage = "Must be 10-300 characters")]
        public string DiscussionBody { get; set; }
    }
}
