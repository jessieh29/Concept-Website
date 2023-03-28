using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SpaceFlightApp.Models.Questions
{
    public class QuestionCreate
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Content is required")]
        [MinLength(20, ErrorMessage = "Must be 20-500 characters")]
        [MaxLength(500, ErrorMessage = "Must be 20-500 characters")]
        public string Faq { get; set; } = String.Empty;


        // [StringLength(200, ErrorMessage = "Question cannot be longer than 200 characters.")]
    }
}
