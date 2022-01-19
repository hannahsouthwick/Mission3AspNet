using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission3WebApp.Models
{
    public class ValidationModel
    {
        [Required]
        [Range(0, 100, ErrorMessage = "Enter a number between 0 to 100")]
        public int assignments { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Enter a number between 0 to 100")]
        public int gproject { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Enter a number between 0 to 100")]
        public int quizzes { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Enter a number between 0 to 100")]
        public int exams { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Enter a number between 0 to 100")]
        public int intex { get; set; }

    }
}
