using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SpaceFlightApp.Models.Questions
{
    public class Question
    {
        public int Id { get; set; }
        public string Faq { get; set; } = String.Empty;


        // [StringLength(200, ErrorMessage = "Question cannot be longer than 200 characters.")]
    }
}




        /* public string FirstMidName { get; set; }

            if (question == null)

                Console.WriteLine("Type a Question to Submit"); 
                
               */
