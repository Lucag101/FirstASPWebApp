using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstASPWebApp.Models
{
    public class CalculatorModel
    {
        // should recieve all values from Calculator, and set them against 1-100 parameters
        // send back if the inputs are outside of 1-100 or empty
        
        [Required]
        [Range(0, 100, ErrorMessage = "Asignments must be between 0 and 100")]
        public string asignments { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Quizzes must be between 0 and 100")]
        public string quizzes { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Projects must be between 0 and 100")]
        public string projects { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Intex must be between 0 and 100")]
        public string intex { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Exams must be between 0 and 100")]
        public string exams { get; set; }
        public string extra { get; set; }

    }

}
